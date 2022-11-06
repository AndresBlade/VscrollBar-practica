namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lstNames = new System.Windows.Forms.ListBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnScroller = new System.Windows.Forms.VScrollBar();
            this.container = new System.Windows.Forms.TableLayoutPanel();
            this.container.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 132);
            this.label1.TabIndex = 0;
            this.label1.Text = "Haga Scroll en la barra izquierda para aumentar o reducir el tamaño del formulari" +
    "o";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstNames
            // 
            this.lstNames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstNames.FormattingEnabled = true;
            this.lstNames.ItemHeight = 25;
            this.lstNames.Location = new System.Drawing.Point(3, 135);
            this.lstNames.Name = "lstNames";
            this.lstNames.Size = new System.Drawing.Size(163, 126);
            this.lstNames.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.Location = new System.Drawing.Point(172, 3);
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = "Ingresa un nombre";
            this.txtName.Size = new System.Drawing.Size(164, 31);
            this.txtName.TabIndex = 2;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.Location = new System.Drawing.Point(172, 135);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(164, 126);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add Name";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnScroller
            // 
            this.btnScroller.AllowDrop = true;
            this.btnScroller.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnScroller.Location = new System.Drawing.Point(339, 0);
            this.btnScroller.Maximum = 200;
            this.btnScroller.Name = "btnScroller";
            this.btnScroller.Size = new System.Drawing.Size(39, 264);
            this.btnScroller.SmallChange = 5;
            this.btnScroller.TabIndex = 4;
            this.btnScroller.Scroll += new System.Windows.Forms.ScrollEventHandler(this.btnScroller_Scroll);
            // 
            // container
            // 
            this.container.AutoSize = true;
            this.container.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.container.ColumnCount = 2;
            this.container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.container.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.container.Controls.Add(this.label1, 0, 0);
            this.container.Controls.Add(this.lstNames, 0, 1);
            this.container.Controls.Add(this.btnAdd, 1, 1);
            this.container.Controls.Add(this.txtName, 1, 0);
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.container.Name = "container";
            this.container.RowCount = 2;
            this.container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.container.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.container.Size = new System.Drawing.Size(339, 264);
            this.container.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 264);
            this.Controls.Add(this.container);
            this.Controls.Add(this.btnScroller);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Names";
            this.container.ResumeLayout(false);
            this.container.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ListBox lstNames;
        private Label label1;
        private TextBox txtName;
        private Button btnAdd;
        private VScrollBar btnScroller;
        private TableLayoutPanel container;
    }
}