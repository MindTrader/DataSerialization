﻿using System;
using System.IO;
using System.Xml;
using Newtonsoft.Json.Linq;

namespace DataSerialization
{
    public class Serializer
    {
        public static string Serialize(string pathToXml)
        {
            //Загрузка XML данных из выбранного файла
            string xmlFile = File.ReadAllText(pathToXml);

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xmlFile);

            //Проверка на наличие и получение массива элементов "ProductOccurence"
            XmlNodeList products = xmlDoc.GetElementsByTagName("ProductOccurence");
            if (products.Count == 0)
                throw (new Exception("Выбранный вами xml не содержит элементов \"ProductOccurence\". Пожалуйста, выберите корректный файл и повторите попытку"));

            JArray jProducts = new JArray();

            //Парсинг элементов ProductOccurence и сериализация в JSON
            foreach (XmlNode product in products)
            {
                XmlNode id = product.Attributes.GetNamedItem("Id");
                XmlNode name = product.Attributes.GetNamedItem("Name");
                XmlNode attrs = product.SelectSingleNode("Attributes");

                //Если текущий элемент "ProductOccurence" не содержит ни единого поля для сериализации - пропускаем его
                if (id == null && name == null && attrs == null)
                    continue;

                //Сериализация полей Id & Name
                JObject jProduct = new JObject();

                jProduct.Add("Id", id != null ? id.Value : "");
                jProduct.Add("Name", name != null ? name.Value : "");

                //Сериализация массива атрибутов (Props)
                JArray jAttrs = new JArray();
                if (attrs != null)
                {
                    foreach (XmlNode attr in attrs.ChildNodes)
                    {
                        JObject jAttr = new JObject();

                        XmlNode attrName = attr.Attributes.GetNamedItem("Name");
                        XmlNode type = attr.Attributes.GetNamedItem("Type");
                        XmlNode value = attr.Attributes.GetNamedItem("Value");

                        if (attrName != null)
                            jAttr.Add("Name", attrName.Value);
                        if (type != null)
                            jAttr.Add("Type", type.Value);
                        if (value != null)
                            jAttr.Add("Value", value.Value);

                        jAttrs.Add(jAttr);
                    }
                }
                jProduct.Add("Props", jAttrs);

                //Завершение сериализации очередного элемента ProductOccurence, добавление в массив
                jProducts.Add(jProduct);
            }
            //Если в xml ни один из элементов ProductOccurence не содержит необходимых данных для сериализации - ошибка сериализации
            if (jProducts.Count == 0)
                throw (new Exception("В выбранном xml ни один из элементов не содержит нужной для сериализации информации"));

            //Метод возвращает строку JSON данных для дальнейшей записи в выбранный пользователем файл
            return jProducts.ToString();
        }
    }
}