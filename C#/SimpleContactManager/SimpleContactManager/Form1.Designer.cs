namespace SimpleContactManager
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private ComboBox comboBox1;
        private Button button1;
        private CheckBox checkBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabPage tabPage2;
        private Button button2;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem filterFavoritesToolStripMenuItem;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox1 = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            checkBox1 = new CheckBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            button2 = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();

            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();

            // TabControl
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(66, 64);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(670, 322);
            tabControl1.TabIndex = 0;

            // TabPage1
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(662, 294);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Contact Entry";
            tabPage1.UseVisualStyleBackColor = true;

            // GroupBox1
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.MistyRose;
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(662, 294);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;

            // Label5
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(398, 170);
            label5.Name = "label5";
            label5.Size = new Size(69, 21);
            label5.TabIndex = 12;
            label5.Text = "Country";

            // Label4
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(398, 50);
            label4.Name = "label4";
            label4.Size = new Size(64, 21);
            label4.TabIndex = 11;
            label4.Text = "Gender";

            // ComboBox1
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "India", "China", "Sri Lanka", "Austria" });
            comboBox1.Location = new Point(476, 168);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(137, 23);
            comboBox1.TabIndex = 10;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;

            // Button1
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(171, 247);
            button1.Name = "button1";
            button1.Size = new Size(172, 41);
            button1.TabIndex = 9;
            button1.Text = "Add to Contact";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;

            // CheckBox1
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(171, 222);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(120, 19);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Mark as Favourite";
            checkBox1.UseVisualStyleBackColor = true;

            // RadioButton2
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(476, 73);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(63, 19);
            radioButton2.TabIndex = 7;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;

            // RadioButton1
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(476, 48);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(51, 19);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;

            // TextBox3
            textBox3.Font = new Font("Segoe UI Symbol", 12F);
            textBox3.Location = new Point(171, 162);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(172, 29);
            textBox3.TabIndex = 5;

            // TextBox2
            textBox2.Font = new Font("Segoe UI Symbol", 12F);
            textBox2.Location = new Point(171, 103);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(172, 29);
            textBox2.TabIndex = 4;

            // TextBox1
            textBox1.Font = new Font("Segoe UI Symbol", 12F);
            textBox1.Location = new Point(171, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(172, 29);
            textBox1.TabIndex = 3;

            // Label3
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(16, 170);
            label3.Name = "label3";
            label3.Size = new Size(120, 21);
            label3.TabIndex = 2;
            label3.Text = "Phone Number";

            // Label2
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(16, 111);
            label2.Name = "label2";
            label2.Size = new Size(48, 21);
            label2.TabIndex = 1;
            label2.Text = "Email";

            // Label1
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(16, 50);
            label1.Name = "label1";
            label1.Size = new Size(53, 21);
            label1.TabIndex = 0;
            label1.Text = "Name";

            // TabPage2
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(listView1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(662, 294);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Contact List";
            tabPage2.UseVisualStyleBackColor = true;

            // Button2
            button2.Location = new Point(487, 19);
            button2.Name = "button2";
            button2.Size = new Size(169, 35);
            button2.TabIndex = 1;
            button2.Text = "Refresh List";
            button2.UseVisualStyleBackColor = true;
            //button2.Click += button2_Click;

            // ListView1
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            listView1.ContextMenuStrip = contextMenuStrip1;
            listView1.Location = new Point(-4, 60);
            listView1.Name = "listView1";
            listView1.Size = new Size(670, 238);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;

            // ColumnHeaders
            columnHeader1.Text = "ID";
            columnHeader2.Text = "Name";
            columnHeader3.Text = "Email";
            columnHeader4.Text = "Phone Number";
            columnHeader4.Width = 100;
            columnHeader5.Text = "Gender";
            columnHeader6.Text = "Favourite";
            columnHeader7.Text = "Country";

            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.filterFavoritesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.filterFavoritesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 92);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // filterFavoritesToolStripMenuItem
            // 
            this.filterFavoritesToolStripMenuItem.Name = "filterFavoritesToolStripMenuItem";
            this.filterFavoritesToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.filterFavoritesToolStripMenuItem.Text = "Filter";
            this.filterFavoritesToolStripMenuItem.Click += new System.EventHandler(this.filterFavoritesToolStripMenuItem_Click);
            //filterFavoritesToolStripMenuItem.Checked = !filterFavoritesToolStripMenuItem.Checked;



            // ToolStripMenuItem1
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(107, 22);
            toolStripMenuItem1.Text = "Edit";
            toolStripMenuItem1.Click += editToolStripMenuItem_Click;

            // ToolStripMenuItem2
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(107, 22);
            toolStripMenuItem2.Text = "Delete";
            toolStripMenuItem2.Click += deleteToolStripMenuItem_Click;

            // ToolStripMenuItem3
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(107, 22);
            toolStripMenuItem3.Text = "Filter";
            toolStripMenuItem3.Click += filterFavoritesToolStripMenuItem_Click;

            // Form1
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Contact Manager";
            Load += Form1_Load;

            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
