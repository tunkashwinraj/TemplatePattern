namespace TemplatePattern_1262774
{
    partial class Form1
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
            this.btnTemplate = new System.Windows.Forms.Button();
            this.btnTemplateAndStrategy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTemplate
            // 
            this.btnTemplate.Location = new System.Drawing.Point(312, 45);
            this.btnTemplate.Name = "btnTemplate";
            this.btnTemplate.Size = new System.Drawing.Size(75, 23);
            this.btnTemplate.TabIndex = 0;
            this.btnTemplate.Text = "btnTemplate";
            this.btnTemplate.UseVisualStyleBackColor = true;
            this.btnTemplate.Click += new System.EventHandler(this.btnTemplate_Click);
            // 
            // btnTemplateAndStrategy
            // 
            this.btnTemplateAndStrategy.Location = new System.Drawing.Point(355, 137);
            this.btnTemplateAndStrategy.Name = "btnTemplateAndStrategy";
            this.btnTemplateAndStrategy.Size = new System.Drawing.Size(168, 23);
            this.btnTemplateAndStrategy.TabIndex = 1;
            this.btnTemplateAndStrategy.Text = "btnTemplateAndStrategy";
            this.btnTemplateAndStrategy.UseVisualStyleBackColor = true;
            this.btnTemplateAndStrategy.Click += new System.EventHandler(this.btnTemplateAndStrategy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTemplateAndStrategy);
            this.Controls.Add(this.btnTemplate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTemplate;
        private System.Windows.Forms.Button btnTemplateAndStrategy;
    }
}

