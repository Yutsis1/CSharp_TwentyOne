namespace First
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.moreBtn = new System.Windows.Forms.Button();
            this.checkBtn = new System.Windows.Forms.Button();
            this.gameField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // moreBtn
            // 
            this.moreBtn.Location = new System.Drawing.Point(12, 358);
            this.moreBtn.Name = "moreBtn";
            this.moreBtn.Size = new System.Drawing.Size(75, 23);
            this.moreBtn.TabIndex = 0;
            this.moreBtn.Text = "More";
            this.moreBtn.UseVisualStyleBackColor = true;
            this.moreBtn.Click += new System.EventHandler(this.MoreBtn_Click);
            // 
            // checkBtn
            // 
            this.checkBtn.Location = new System.Drawing.Point(350, 358);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(75, 23);
            this.checkBtn.TabIndex = 1;
            this.checkBtn.Text = "Check";
            this.checkBtn.UseVisualStyleBackColor = true;
            this.checkBtn.Click += new System.EventHandler(this.CheckBtn_Click);
            // 
            // gameField
            // 
            this.gameField.Location = new System.Drawing.Point(12, 12);
            this.gameField.Name = "gameField";
            this.gameField.Size = new System.Drawing.Size(100, 22);
            this.gameField.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 393);
            this.Controls.Add(this.gameField);
            this.Controls.Add(this.checkBtn);
            this.Controls.Add(this.moreBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button moreBtn;
        private System.Windows.Forms.Button checkBtn;
        private System.Windows.Forms.TextBox gameField;
    }
}

