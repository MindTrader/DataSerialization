namespace DataSerialization
{
    partial class fMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSelectXml = new System.Windows.Forms.Button();
            this.tbXmlPath = new System.Windows.Forms.TextBox();
            this.btnSerialize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSelectXml
            // 
            this.btnSelectXml.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelectXml.Location = new System.Drawing.Point(584, 153);
            this.btnSelectXml.Name = "btnSelectXml";
            this.btnSelectXml.Size = new System.Drawing.Size(182, 37);
            this.btnSelectXml.TabIndex = 0;
            this.btnSelectXml.Text = "Выбрать файл";
            this.btnSelectXml.UseVisualStyleBackColor = true;
            this.btnSelectXml.Click += new System.EventHandler(this.btnSelectXml_Click);
            // 
            // tbXmlPath
            // 
            this.tbXmlPath.BackColor = System.Drawing.SystemColors.Control;
            this.tbXmlPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbXmlPath.Location = new System.Drawing.Point(12, 159);
            this.tbXmlPath.Multiline = true;
            this.tbXmlPath.Name = "tbXmlPath";
            this.tbXmlPath.ReadOnly = true;
            this.tbXmlPath.Size = new System.Drawing.Size(566, 24);
            this.tbXmlPath.TabIndex = 2;
            this.tbXmlPath.Text = "Выберите .xml файл для дальнейшей сериализации";
            this.tbXmlPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSerialize
            // 
            this.btnSerialize.Enabled = false;
            this.btnSerialize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSerialize.Location = new System.Drawing.Point(275, 350);
            this.btnSerialize.Name = "btnSerialize";
            this.btnSerialize.Size = new System.Drawing.Size(229, 36);
            this.btnSerialize.TabIndex = 4;
            this.btnSerialize.Text = "Сериализовать данные";
            this.btnSerialize.UseVisualStyleBackColor = true;
            this.btnSerialize.Click += new System.EventHandler(this.btnSerialize_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 424);
            this.Controls.Add(this.btnSerialize);
            this.Controls.Add(this.tbXmlPath);
            this.Controls.Add(this.btnSelectXml);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Serializer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectXml;
        private System.Windows.Forms.TextBox tbXmlPath;
        private System.Windows.Forms.Button btnSerialize;
    }
}

