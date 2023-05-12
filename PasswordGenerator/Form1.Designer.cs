namespace PasswordGenerator
{
    partial class FrmPasswordGenerator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPasswordGenerator));
            this.ParamsGeneration = new System.Windows.Forms.GroupBox();
            this.trackBarPasswordLenght = new System.Windows.Forms.TrackBar();
            this.textPasswordLenght = new System.Windows.Forms.Label();
            this.CheckBoxUppercaseLetters = new System.Windows.Forms.CheckBox();
            this.CheckBoxLowercaseLetters = new System.Windows.Forms.CheckBox();
            this.CheckBoxDigits = new System.Windows.Forms.CheckBox();
            this.CheckBoxSpecialSymbols = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ButtonGeneratePassword = new System.Windows.Forms.Button();
            this.ButtonClearPassword = new System.Windows.Forms.Button();
            this.textBoxGenerationPassword = new System.Windows.Forms.TextBox();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.LabelPasswordCopiedToClipboard = new System.Windows.Forms.Label();
            this.TimerShowLabelCopy = new System.Windows.Forms.Timer(this.components);
            this.ParamsGeneration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPasswordLenght)).BeginInit();
            this.SuspendLayout();
            // 
            // ParamsGeneration
            // 
            this.ParamsGeneration.Controls.Add(this.trackBarPasswordLenght);
            this.ParamsGeneration.Controls.Add(this.textPasswordLenght);
            this.ParamsGeneration.Controls.Add(this.CheckBoxUppercaseLetters);
            this.ParamsGeneration.Controls.Add(this.CheckBoxLowercaseLetters);
            this.ParamsGeneration.Controls.Add(this.CheckBoxDigits);
            this.ParamsGeneration.Controls.Add(this.CheckBoxSpecialSymbols);
            this.ParamsGeneration.Location = new System.Drawing.Point(12, 12);
            this.ParamsGeneration.Name = "ParamsGeneration";
            this.ParamsGeneration.Size = new System.Drawing.Size(755, 171);
            this.ParamsGeneration.TabIndex = 0;
            this.ParamsGeneration.TabStop = false;
            this.ParamsGeneration.Text = "Параметры генерации пароля";
            // 
            // trackBarPasswordLenght
            // 
            this.trackBarPasswordLenght.Location = new System.Drawing.Point(381, 109);
            this.trackBarPasswordLenght.Maximum = 30;
            this.trackBarPasswordLenght.Minimum = 5;
            this.trackBarPasswordLenght.Name = "trackBarPasswordLenght";
            this.trackBarPasswordLenght.Size = new System.Drawing.Size(368, 56);
            this.trackBarPasswordLenght.TabIndex = 4;
            this.trackBarPasswordLenght.Value = 5;
            // 
            // textPasswordLenght
            // 
            this.textPasswordLenght.AutoSize = true;
            this.textPasswordLenght.Location = new System.Drawing.Point(277, 121);
            this.textPasswordLenght.Name = "textPasswordLenght";
            this.textPasswordLenght.Size = new System.Drawing.Size(98, 16);
            this.textPasswordLenght.TabIndex = 5;
            this.textPasswordLenght.Text = "Длина пароля";
            // 
            // CheckBoxUppercaseLetters
            // 
            this.CheckBoxUppercaseLetters.AutoSize = true;
            this.CheckBoxUppercaseLetters.Location = new System.Drawing.Point(9, 89);
            this.CheckBoxUppercaseLetters.Name = "CheckBoxUppercaseLetters";
            this.CheckBoxUppercaseLetters.Size = new System.Drawing.Size(349, 20);
            this.CheckBoxUppercaseLetters.TabIndex = 3;
            this.CheckBoxUppercaseLetters.Text = " Использовать прописные латинские буквы: A - Z";
            this.CheckBoxUppercaseLetters.UseVisualStyleBackColor = true;
            this.CheckBoxUppercaseLetters.CheckedChanged += new System.EventHandler(this.CheckBoxUppercaseLetters_CheckedChanged);
            // 
            // CheckBoxLowercaseLetters
            // 
            this.CheckBoxLowercaseLetters.AutoSize = true;
            this.CheckBoxLowercaseLetters.Location = new System.Drawing.Point(9, 66);
            this.CheckBoxLowercaseLetters.Name = "CheckBoxLowercaseLetters";
            this.CheckBoxLowercaseLetters.Size = new System.Drawing.Size(334, 20);
            this.CheckBoxLowercaseLetters.TabIndex = 2;
            this.CheckBoxLowercaseLetters.Text = "Использовать строчные латинские буквы: a - z";
            this.CheckBoxLowercaseLetters.UseVisualStyleBackColor = true;
            this.CheckBoxLowercaseLetters.CheckedChanged += new System.EventHandler(this.CheckBoxLowercaseLetters_CheckedChanged);
            // 
            // CheckBoxDigits
            // 
            this.CheckBoxDigits.AutoSize = true;
            this.CheckBoxDigits.Location = new System.Drawing.Point(9, 43);
            this.CheckBoxDigits.Name = "CheckBoxDigits";
            this.CheckBoxDigits.Size = new System.Drawing.Size(200, 20);
            this.CheckBoxDigits.TabIndex = 1;
            this.CheckBoxDigits.Text = "Использовать цифры: 0 - 9";
            this.CheckBoxDigits.UseVisualStyleBackColor = true;
            this.CheckBoxDigits.CheckedChanged += new System.EventHandler(this.CheckBoxDigits_CheckedChanged);
            // 
            // CheckBoxSpecialSymbols
            // 
            this.CheckBoxSpecialSymbols.AutoSize = true;
            this.CheckBoxSpecialSymbols.Location = new System.Drawing.Point(9, 20);
            this.CheckBoxSpecialSymbols.Name = "CheckBoxSpecialSymbols";
            this.CheckBoxSpecialSymbols.Size = new System.Drawing.Size(482, 20);
            this.CheckBoxSpecialSymbols.TabIndex = 0;
            this.CheckBoxSpecialSymbols.Text = "Использовать специальные символы: #  !  $  ;  _  ?  &&  ^  %  @  *  (  )  {  }  [" +
    "  ]";
            this.CheckBoxSpecialSymbols.UseVisualStyleBackColor = true;
            this.CheckBoxSpecialSymbols.CheckedChanged += new System.EventHandler(this.CheckBoxSpecialSymbols_CheckedChanged);
            // 
            // ButtonGeneratePassword
            // 
            this.ButtonGeneratePassword.Location = new System.Drawing.Point(32, 189);
            this.ButtonGeneratePassword.Name = "ButtonGeneratePassword";
            this.ButtonGeneratePassword.Size = new System.Drawing.Size(172, 23);
            this.ButtonGeneratePassword.TabIndex = 7;
            this.ButtonGeneratePassword.Text = "Сгенерировать пароль";
            this.ButtonGeneratePassword.UseVisualStyleBackColor = true;
            this.ButtonGeneratePassword.Click += new System.EventHandler(this.ButtonGeneratePassword_Click);
            // 
            // ButtonClearPassword
            // 
            this.ButtonClearPassword.Location = new System.Drawing.Point(657, 189);
            this.ButtonClearPassword.Name = "ButtonClearPassword";
            this.ButtonClearPassword.Size = new System.Drawing.Size(104, 23);
            this.ButtonClearPassword.TabIndex = 9;
            this.ButtonClearPassword.Text = "Стереть";
            this.ButtonClearPassword.UseVisualStyleBackColor = true;
            this.ButtonClearPassword.Click += new System.EventHandler(this.ButtonClearPassword_Click);
            // 
            // textBoxGenerationPassword
            // 
            this.textBoxGenerationPassword.Location = new System.Drawing.Point(210, 189);
            this.textBoxGenerationPassword.Name = "textBoxGenerationPassword";
            this.textBoxGenerationPassword.Size = new System.Drawing.Size(233, 22);
            this.textBoxGenerationPassword.TabIndex = 10;
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(449, 188);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(104, 23);
            this.buttonCopy.TabIndex = 11;
            this.buttonCopy.Text = "Копировать";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // LabelPasswordCopiedToClipboard
            // 
            this.LabelPasswordCopiedToClipboard.AutoSize = true;
            this.LabelPasswordCopiedToClipboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPasswordCopiedToClipboard.ForeColor = System.Drawing.Color.Green;
            this.LabelPasswordCopiedToClipboard.Location = new System.Drawing.Point(193, 215);
            this.LabelPasswordCopiedToClipboard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelPasswordCopiedToClipboard.Name = "LabelPasswordCopiedToClipboard";
            this.LabelPasswordCopiedToClipboard.Size = new System.Drawing.Size(280, 17);
            this.LabelPasswordCopiedToClipboard.TabIndex = 12;
            this.LabelPasswordCopiedToClipboard.Text = "Пароль скопирован в буфер обмена";
            this.LabelPasswordCopiedToClipboard.Visible = false;
            // 
            // TimerShowLabelCopy
            // 
            this.TimerShowLabelCopy.Interval = 2000;
            this.TimerShowLabelCopy.Tick += new System.EventHandler(this.TimerShowLabelCopy_Tick_1);
            // 
            // FrmPasswordGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 258);
            this.Controls.Add(this.LabelPasswordCopiedToClipboard);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.textBoxGenerationPassword);
            this.Controls.Add(this.ButtonGeneratePassword);
            this.Controls.Add(this.ButtonClearPassword);
            this.Controls.Add(this.ParamsGeneration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPasswordGenerator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Генератор паролей";
            this.Load += new System.EventHandler(this.FrmPasswordGenerator_Load);
            this.ParamsGeneration.ResumeLayout(false);
            this.ParamsGeneration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPasswordLenght)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ParamsGeneration;
        private System.Windows.Forms.TrackBar trackBarPasswordLenght;
        private System.Windows.Forms.Label textPasswordLenght;
        private System.Windows.Forms.CheckBox CheckBoxUppercaseLetters;
        private System.Windows.Forms.CheckBox CheckBoxLowercaseLetters;
        private System.Windows.Forms.CheckBox CheckBoxDigits;
        private System.Windows.Forms.CheckBox CheckBoxSpecialSymbols;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button ButtonGeneratePassword;
        private System.Windows.Forms.Button ButtonClearPassword;
        private System.Windows.Forms.TextBox textBoxGenerationPassword;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Label LabelPasswordCopiedToClipboard;
        private System.Windows.Forms.Timer TimerShowLabelCopy;
    }
}

