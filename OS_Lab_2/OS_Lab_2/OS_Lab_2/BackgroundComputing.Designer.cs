namespace OS_Lab_2
{
    partial class BackgroundComputing
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.textBoxFileCopy = new System.Windows.Forms.TextBox();
            this.buttonFile = new System.Windows.Forms.Button();
            this.buttonFileCopy = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonCopyInSeparateThread = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Исходный файл";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Файл - Копия";
            // 
            // textBoxFile
            // 
            this.textBoxFile.Location = new System.Drawing.Point(105, 23);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.Size = new System.Drawing.Size(262, 20);
            this.textBoxFile.TabIndex = 2;
            // 
            // textBoxFileCopy
            // 
            this.textBoxFileCopy.Location = new System.Drawing.Point(105, 56);
            this.textBoxFileCopy.Name = "textBoxFileCopy";
            this.textBoxFileCopy.Size = new System.Drawing.Size(262, 20);
            this.textBoxFileCopy.TabIndex = 3;
            // 
            // buttonFile
            // 
            this.buttonFile.Location = new System.Drawing.Point(373, 20);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(28, 23);
            this.buttonFile.TabIndex = 4;
            this.buttonFile.Text = "...";
            this.buttonFile.UseVisualStyleBackColor = true;
            this.buttonFile.Click += new System.EventHandler(this.buttonFile_Click);
            // 
            // buttonFileCopy
            // 
            this.buttonFileCopy.Location = new System.Drawing.Point(373, 53);
            this.buttonFileCopy.Name = "buttonFileCopy";
            this.buttonFileCopy.Size = new System.Drawing.Size(28, 23);
            this.buttonFileCopy.TabIndex = 5;
            this.buttonFileCopy.Text = "...";
            this.buttonFileCopy.UseVisualStyleBackColor = true;
            this.buttonFileCopy.Click += new System.EventHandler(this.buttonFileCopy_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(15, 95);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(143, 40);
            this.buttonCopy.TabIndex = 6;
            this.buttonCopy.Text = "Копировать";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonCopyInSeparateThread
            // 
            this.buttonCopyInSeparateThread.Location = new System.Drawing.Point(258, 95);
            this.buttonCopyInSeparateThread.Name = "buttonCopyInSeparateThread";
            this.buttonCopyInSeparateThread.Size = new System.Drawing.Size(143, 40);
            this.buttonCopyInSeparateThread.TabIndex = 7;
            this.buttonCopyInSeparateThread.Text = "Копировать в отдельном потоке";
            this.buttonCopyInSeparateThread.UseVisualStyleBackColor = true;
            this.buttonCopyInSeparateThread.Click += new System.EventHandler(this.buttonCopyInSeparateThread_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 142);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(410, 43);
            this.progressBar1.TabIndex = 8;
            // 
            // BackgroundComputing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 185);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonCopyInSeparateThread);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.buttonFileCopy);
            this.Controls.Add(this.buttonFile);
            this.Controls.Add(this.textBoxFileCopy);
            this.Controls.Add(this.textBoxFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(426, 224);
            this.MinimumSize = new System.Drawing.Size(426, 224);
            this.Name = "BackgroundComputing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BackgroundComputing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFile;
        private System.Windows.Forms.TextBox textBoxFileCopy;
        private System.Windows.Forms.Button buttonFile;
        private System.Windows.Forms.Button buttonFileCopy;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonCopyInSeparateThread;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

