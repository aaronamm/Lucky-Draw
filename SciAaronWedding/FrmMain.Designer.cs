namespace SciAaronWedding
{
    partial class FrmMain
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
            this.BtnLuckyDraw = new System.Windows.Forms.Button();
            this.LblLuckyNumber = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mMain = new System.Windows.Forms.ToolStripMenuItem();
            this.mLuckyList = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnLuckyDraw
            // 
            this.BtnLuckyDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLuckyDraw.Location = new System.Drawing.Point(98, 274);
            this.BtnLuckyDraw.Name = "BtnLuckyDraw";
            this.BtnLuckyDraw.Size = new System.Drawing.Size(273, 63);
            this.BtnLuckyDraw.TabIndex = 0;
            this.BtnLuckyDraw.Text = "Lucky Draw";
            this.BtnLuckyDraw.UseVisualStyleBackColor = true;
            this.BtnLuckyDraw.Click += new System.EventHandler(this.BtnLuckyDraw_Click);
            // 
            // LblLuckyNumber
            // 
            this.LblLuckyNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 64F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLuckyNumber.Location = new System.Drawing.Point(40, 65);
            this.LblLuckyNumber.Name = "LblLuckyNumber";
            this.LblLuckyNumber.Size = new System.Drawing.Size(388, 156);
            this.LblLuckyNumber.TabIndex = 1;
            this.LblLuckyNumber.Text = "LUCKEY";
            this.LblLuckyNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mMain});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(465, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mMain
            // 
            this.mMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mLuckyList});
            this.mMain.Name = "mMain";
            this.mMain.Size = new System.Drawing.Size(50, 20);
            this.mMain.Text = "menu";
            // 
            // mLuckyList
            // 
            this.mLuckyList.Name = "mLuckyList";
            this.mLuckyList.Size = new System.Drawing.Size(126, 22);
            this.mLuckyList.Text = "Lucky List";
            this.mLuckyList.Click += new System.EventHandler(this.MLuckyList_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 370);
            this.Controls.Add(this.LblLuckyNumber);
            this.Controls.Add(this.BtnLuckyDraw);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aaron loves Sci";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLuckyDraw;
        private System.Windows.Forms.Label LblLuckyNumber;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mMain;
        private System.Windows.Forms.ToolStripMenuItem mLuckyList;
    }
}

