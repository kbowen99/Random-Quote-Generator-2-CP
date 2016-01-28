namespace RandyQuoteGen
{
    partial class frm_randyQuoteGenForm
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
            this.btn_Randy = new System.Windows.Forms.Button();
            this.pic_quotebox = new System.Windows.Forms.PictureBox();
            this.pic_Background = new System.Windows.Forms.PictureBox();
            this.lbl_Num = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_quotebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Background)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Randy
            // 
            this.btn_Randy.Location = new System.Drawing.Point(12, 486);
            this.btn_Randy.Name = "btn_Randy";
            this.btn_Randy.Size = new System.Drawing.Size(535, 63);
            this.btn_Randy.TabIndex = 3;
            this.btn_Randy.Text = "Random Internet Quote";
            this.btn_Randy.UseVisualStyleBackColor = true;
            this.btn_Randy.Click += new System.EventHandler(this.btn_Randy_Click);
            // 
            // pic_quotebox
            // 
            this.pic_quotebox.BackColor = System.Drawing.Color.DimGray;
            this.pic_quotebox.Image = global::RandyQuoteGen.Properties.Resources.cooltext1721520660;
            this.pic_quotebox.Location = new System.Drawing.Point(12, 60);
            this.pic_quotebox.Name = "pic_quotebox";
            this.pic_quotebox.Size = new System.Drawing.Size(535, 341);
            this.pic_quotebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_quotebox.TabIndex = 4;
            this.pic_quotebox.TabStop = false;
            //this.pic_quotebox.Click += new System.EventHandler(this.pic_quotebox_Click);
            // 
            // pic_Background
            // 
            this.pic_Background.Image = global::RandyQuoteGen.Properties.Resources.congruent_outline;
            this.pic_Background.Location = new System.Drawing.Point(-3, -2);
            this.pic_Background.Name = "pic_Background";
            this.pic_Background.Size = new System.Drawing.Size(564, 566);
            this.pic_Background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_Background.TabIndex = 0;
            this.pic_Background.TabStop = false;
            //this.pic_Background.Click += new System.EventHandler(this.pic_Background_Click);
            // 
            // lbl_Num
            // 
            this.lbl_Num.AutoSize = true;
            this.lbl_Num.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Num.Location = new System.Drawing.Point(12, 377);
            this.lbl_Num.Name = "lbl_Num";
            this.lbl_Num.Size = new System.Drawing.Size(20, 24);
            this.lbl_Num.TabIndex = 5;
            this.lbl_Num.Text = "0";
            // 
            // frm_randyQuoteGenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 561);
            this.Controls.Add(this.lbl_Num);
            this.Controls.Add(this.pic_quotebox);
            this.Controls.Add(this.btn_Randy);
            this.Controls.Add(this.pic_Background);
            this.Name = "frm_randyQuoteGenForm";
            this.Text = "Random Picture Quote Gen";
            ((System.ComponentModel.ISupportInitialize)(this.pic_quotebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Background;
        private System.Windows.Forms.Button btn_Randy;
        private System.Windows.Forms.PictureBox pic_quotebox;
        private System.Windows.Forms.Label lbl_Num;
    }
}

