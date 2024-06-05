namespace gameofcrapsbenim
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLives = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxGirdi = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblDisplay1 = new System.Windows.Forms.Label();
            this.lblDisplay2 = new System.Windows.Forms.Label();
            this.lblDisplay3 = new System.Windows.Forms.Label();
            this.lblDisplay4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            resources.ApplyResources(this.btnStart, "btnStart");
            this.btnStart.Name = "btnStart";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lblLives
            // 
            resources.ApplyResources(this.lblLives, "lblLives");
            this.lblLives.Name = "lblLives";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtBoxGirdi
            // 
            resources.ApplyResources(this.txtBoxGirdi, "txtBoxGirdi");
            this.txtBoxGirdi.Name = "txtBoxGirdi";
            // 
            // btnCheck
            // 
            resources.ApplyResources(this.btnCheck, "btnCheck");
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblDisplay1
            // 
            resources.ApplyResources(this.lblDisplay1, "lblDisplay1");
            this.lblDisplay1.Name = "lblDisplay1";
            // 
            // lblDisplay2
            // 
            resources.ApplyResources(this.lblDisplay2, "lblDisplay2");
            this.lblDisplay2.Name = "lblDisplay2";
            // 
            // lblDisplay3
            // 
            resources.ApplyResources(this.lblDisplay3, "lblDisplay3");
            this.lblDisplay3.ForeColor = System.Drawing.Color.Red;
            this.lblDisplay3.Name = "lblDisplay3";
            // 
            // lblDisplay4
            // 
            resources.ApplyResources(this.lblDisplay4, "lblDisplay4");
            this.lblDisplay4.ForeColor = System.Drawing.Color.Green;
            this.lblDisplay4.Name = "lblDisplay4";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDisplay4);
            this.Controls.Add(this.lblDisplay3);
            this.Controls.Add(this.lblDisplay2);
            this.Controls.Add(this.lblDisplay1);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtBoxGirdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblLives);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLives;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxGirdi;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblDisplay1;
        private System.Windows.Forms.Label lblDisplay2;
        private System.Windows.Forms.Label lblDisplay3;
        private System.Windows.Forms.Label lblDisplay4;
    }
}

