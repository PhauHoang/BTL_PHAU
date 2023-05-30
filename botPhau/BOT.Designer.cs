namespace botPhau
{
    partial class bot
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
            this.txtbot = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtbot
            // 
            this.txtbot.BackColor = System.Drawing.SystemColors.Info;
            this.txtbot.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbot.ForeColor = System.Drawing.Color.LightCoral;
            this.txtbot.Location = new System.Drawing.Point(25, 54);
            this.txtbot.Multiline = true;
            this.txtbot.Name = "txtbot";
            this.txtbot.Size = new System.Drawing.Size(730, 357);
            this.txtbot.TabIndex = 0;
            this.txtbot.TextChanged += new System.EventHandler(this.txtbot_TextChanged);
            // 
            // bot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtbot);
            this.Name = "bot";
            this.Text = "bot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbot;
    }
}

