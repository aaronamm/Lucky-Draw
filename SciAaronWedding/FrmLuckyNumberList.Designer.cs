namespace SciAaronWedding
{
    partial class FrmLuckyNumberList
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
            this.LblLuckyList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblLuckyList
            // 
            this.LblLuckyList.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLuckyList.Location = new System.Drawing.Point(97, 35);
            this.LblLuckyList.Name = "LblLuckyList";
            this.LblLuckyList.Size = new System.Drawing.Size(181, 353);
            this.LblLuckyList.TabIndex = 0;
            this.LblLuckyList.Text = "Lucky Number";
            this.LblLuckyList.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmLuckyNumberList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 421);
            this.Controls.Add(this.LblLuckyList);
            this.Name = "FrmLuckyNumberList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "รายชื่อผู้โชคดี";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblLuckyList;
    }
}