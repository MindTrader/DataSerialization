using System;
using System.Xml;
using Newtonsoft.Json.Linq;

namespace DataSerialization
{
    public class Serializer
    {
        public static string Serialize(string pathToXml)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(pathToXml);

            XmlNodeList products = xmlDoc.GetElementsByTagName("ProductOccurence");
            if (products.Count == 0)
                throw (new Exception("Выбранный вами xml не содержит элементов \"ProductOccurence\". Пожалуйста, выберите корректный файл и повторите попытку"));

            JArray jProducts = new JArray();

            //Парсинг элементов ProductOccurence и их сериализация
            foreach (XmlNode product in products)
            {
                XmlNode id = product.Attributes.GetNamedItem("Id");
                XmlNode name = product.Attributes.GetNamedItem("Name");
                XmlNode attrs = product.SelectSingleNode("Attributes");

                if (id == null && name == null && attrs == null) //Если есть пустые элементы - пропускаем
                    continue;

                //Сериализация массива атрибутов (Props)
                JArray jAttrs = new JArray();
                if (attrs != null)
                {
                    foreach (XmlNode attr in attrs.ChildNodes)
                    {
                        XmlNode attrName = attr.Attributes.GetNamedItem("Name");
                        XmlNode type = attr.Attributes.GetNamedItem("Type");
                        XmlNode value = attr.Attributes.GetNamedItem("Value");

                        JObject jAttr = new JObject
                        {
                            { "Name", attrName != null ? attrName.Value : "" },
                            { "Type", type != null ? type.Value : "" },
                            { "Value", value != null ? value.Value : "" }
                        };

                        jAttrs.Add(jAttr);
                    }
                }

                JObject jProduct = new JObject
                {
                    { "Id", id != null ? id.Value : "" },
                    { "Name", name != null ? name.Value : "" },
                    { "Props",  jAttrs}
                };

                jProducts.Add(jProduct);
            }
            if (jProducts.Count == 0) //Если в xml ни один из элементов ProductOccurence не содержит необходимых данных для сериализации - ошибка сериализации
                throw (new Exception("В выбранном xml ни один из элементов не содержит нужной для сериализации информации"));

            return jProducts.ToString();
        }
    }
}