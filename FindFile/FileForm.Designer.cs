
namespace FindFile
{
    partial class FileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileForm));
            this.labelWhere = new System.Windows.Forms.Label();
            this.labelWhat = new System.Windows.Forms.Label();
            this.textBoxWhere = new System.Windows.Forms.TextBox();
            this.textBoxWhat = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonWhat = new System.Windows.Forms.Button();
            this.buttonWhere = new System.Windows.Forms.Button();
            this.checkName = new System.Windows.Forms.CheckBox();
            this.checkExt = new System.Windows.Forms.CheckBox();
            this.checkCreate = new System.Windows.Forms.CheckBox();
            this.checkLast = new System.Windows.Forms.CheckBox();
            this.checkOpen = new System.Windows.Forms.CheckBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // labelWhere
            // 
            this.labelWhere.AutoSize = true;
            this.labelWhere.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWhere.Location = new System.Drawing.Point(9, 9);
            this.labelWhere.Name = "labelWhere";
            this.labelWhere.Size = new System.Drawing.Size(50, 17);
            this.labelWhere.TabIndex = 0;
            this.labelWhere.Text = "Where";
            // 
            // labelWhat
            // 
            this.labelWhat.AutoSize = true;
            this.labelWhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWhat.Location = new System.Drawing.Point(9, 62);
            this.labelWhat.Name = "labelWhat";
            this.labelWhat.Size = new System.Drawing.Size(41, 17);
            this.labelWhat.TabIndex = 1;
            this.labelWhat.Text = "What";
            // 
            // textBoxWhere
            // 
            this.textBoxWhere.Location = new System.Drawing.Point(12, 36);
            this.textBoxWhere.Name = "textBoxWhere";
            this.textBoxWhere.Size = new System.Drawing.Size(201, 20);
            this.textBoxWhere.TabIndex = 2;
            // 
            // textBoxWhat
            // 
            this.textBoxWhat.Location = new System.Drawing.Point(12, 93);
            this.textBoxWhat.Name = "textBoxWhat";
            this.textBoxWhat.Size = new System.Drawing.Size(201, 20);
            this.textBoxWhat.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 183);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(201, 134);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // buttonWhat
            // 
            this.buttonWhat.Location = new System.Drawing.Point(118, 62);
            this.buttonWhat.Name = "buttonWhat";
            this.buttonWhat.Size = new System.Drawing.Size(95, 23);
            this.buttonWhat.TabIndex = 5;
            this.buttonWhat.Text = "Find";
            this.buttonWhat.UseVisualStyleBackColor = true;
            this.buttonWhat.Click += new System.EventHandler(this.buttonWhat_Click);
            // 
            // buttonWhere
            // 
            this.buttonWhere.Location = new System.Drawing.Point(118, 9);
            this.buttonWhere.Name = "buttonWhere";
            this.buttonWhere.Size = new System.Drawing.Size(95, 23);
            this.buttonWhere.TabIndex = 6;
            this.buttonWhere.Text = "Open";
            this.buttonWhere.UseVisualStyleBackColor = true;
            this.buttonWhere.Click += new System.EventHandler(this.buttonWhere_Click);
            // 
            // checkName
            // 
            this.checkName.AutoSize = true;
            this.checkName.Location = new System.Drawing.Point(17, 125);
            this.checkName.Name = "checkName";
            this.checkName.Size = new System.Drawing.Size(63, 17);
            this.checkName.TabIndex = 7;
            this.checkName.Text = "in name";
            this.checkName.UseVisualStyleBackColor = true;
            // 
            // checkExt
            // 
            this.checkExt.AutoSize = true;
            this.checkExt.Location = new System.Drawing.Point(17, 148);
            this.checkExt.Name = "checkExt";
            this.checkExt.Size = new System.Drawing.Size(51, 17);
            this.checkExt.TabIndex = 8;
            this.checkExt.Text = "in ext";
            this.checkExt.UseVisualStyleBackColor = true;
            // 
            // checkCreate
            // 
            this.checkCreate.AutoSize = true;
            this.checkCreate.Location = new System.Drawing.Point(118, 116);
            this.checkCreate.Name = "checkCreate";
            this.checkCreate.Size = new System.Drawing.Size(99, 17);
            this.checkCreate.TabIndex = 9;
            this.checkCreate.Text = "in creation date";
            this.checkCreate.UseVisualStyleBackColor = true;
            // 
            // checkLast
            // 
            this.checkLast.AutoSize = true;
            this.checkLast.Location = new System.Drawing.Point(118, 139);
            this.checkLast.Name = "checkLast";
            this.checkLast.Size = new System.Drawing.Size(81, 17);
            this.checkLast.TabIndex = 10;
            this.checkLast.Text = "in last modif";
            this.checkLast.UseVisualStyleBackColor = true;
            // 
            // checkOpen
            // 
            this.checkOpen.AutoSize = true;
            this.checkOpen.Location = new System.Drawing.Point(118, 162);
            this.checkOpen.Name = "checkOpen";
            this.checkOpen.Size = new System.Drawing.Size(80, 17);
            this.checkOpen.TabIndex = 11;
            this.checkOpen.Text = "in last open";
            this.checkOpen.UseVisualStyleBackColor = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "FileFinder";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 329);
            this.Controls.Add(this.checkOpen);
            this.Controls.Add(this.checkLast);
            this.Controls.Add(this.checkCreate);
            this.Controls.Add(this.checkExt);
            this.Controls.Add(this.checkName);
            this.Controls.Add(this.buttonWhere);
            this.Controls.Add(this.buttonWhat);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBoxWhat);
            this.Controls.Add(this.textBoxWhere);
            this.Controls.Add(this.labelWhat);
            this.Controls.Add(this.labelWhere);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "FileFinder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWhere;
        private System.Windows.Forms.Label labelWhat;
        private System.Windows.Forms.TextBox textBoxWhere;
        private System.Windows.Forms.TextBox textBoxWhat;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonWhat;
        private System.Windows.Forms.Button buttonWhere;
        private System.Windows.Forms.CheckBox checkName;
        private System.Windows.Forms.CheckBox checkExt;
        private System.Windows.Forms.CheckBox checkCreate;
        private System.Windows.Forms.CheckBox checkLast;
        private System.Windows.Forms.CheckBox checkOpen;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

