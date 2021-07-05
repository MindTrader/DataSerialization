namespace DataSerialization
{
    partial class fMsg
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
            this.tbMsg = new System.Windows.Forms.TextBox();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbMsg
            // 
            this.tbMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbMsg.Location = new System.Drawing.Point(13, 25);
            this.tbMsg.Multiline = true;
            this.tbMsg.Name = "tbMsg";
            this.tbMsg.ReadOnly = true;
            this.tbMsg.Size = new System.Drawing.Size(307, 131);
            this.tbMsg.TabIndex = 2;
            this.tbMsg.TabStop = false;
            this.tbMsg.Text = "Выбранный вами файл имеет расширение, отличное от .xml\r\n\r\nВы уверены, что хотите " +
    "использовать данный файл?";
            this.tbMsg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnYes
            // 
            this.btnYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnYes.Location = new System.Drawing.Point(27, 204);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(101, 45);
            this.btnYes.TabIndex = 4;
            this.btnYes.Text = "Да";
            this.btnYes.UseVisualStyleBackColor = true;
            // 
            // btnNo
            // 
            this.btnNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNo.Location = new System.Drawing.Point(210, 204);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(101, 45);
            this.btnNo.TabIndex = 3;
            this.btnNo.Text = "Нет";
            this.btnNo.UseVisualStyleBackColor = true;
            // 
            // fMsg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 271);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.tbMsg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fMsg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Incorrect file\'s extension";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMsg;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
    }
}