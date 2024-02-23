namespace CRUD_application
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
            create = new Button();
            read = new Button();
            update = new Button();
            delete = new Button();
            create_txtbox = new TextBox();
            create_lbl = new Label();
            create_btn = new Button();
            read_txtbox = new TextBox();
            read_lbl = new Label();
            read_indx_btn = new Button();
            read_indx = new Button();
            read_list = new Button();
            back = new Button();
            read_richTextBox = new RichTextBox();
            read_list_btn = new Button();
            update_origin_lbl = new Label();
            update_txtBox_origin_value = new TextBox();
            update_txtBox_new_value = new TextBox();
            update_btn = new Button();
            update_new_lbl = new Label();
            delete_value_lbl = new Label();
            delete_txtBox = new TextBox();
            delete_btn = new Button();
            SuspendLayout();
            // 
            // create
            // 
            create.Location = new Point(101, 94);
            create.Name = "create";
            create.Size = new Size(94, 29);
            create.TabIndex = 0;
            create.Text = "CREATE";
            create.UseVisualStyleBackColor = true;
            create.Click += create_Click;
            // 
            // read
            // 
            read.Location = new Point(242, 94);
            read.Name = "read";
            read.Size = new Size(94, 29);
            read.TabIndex = 1;
            read.Text = "READ";
            read.UseVisualStyleBackColor = true;
            read.Click += read_Click;
            // 
            // update
            // 
            update.Location = new Point(404, 94);
            update.Name = "update";
            update.Size = new Size(94, 29);
            update.TabIndex = 2;
            update.Text = "UPDATE";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // delete
            // 
            delete.Location = new Point(555, 94);
            delete.Name = "delete";
            delete.Size = new Size(94, 29);
            delete.TabIndex = 3;
            delete.Text = "DELETE";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // create_txtbox
            // 
            create_txtbox.Location = new Point(312, 179);
            create_txtbox.Name = "create_txtbox";
            create_txtbox.Size = new Size(125, 27);
            create_txtbox.TabIndex = 4;
            create_txtbox.Visible = false;
            // 
            // create_lbl
            // 
            create_lbl.AutoSize = true;
            create_lbl.Location = new Point(256, 182);
            create_lbl.Name = "create_lbl";
            create_lbl.Size = new Size(48, 20);
            create_lbl.TabIndex = 5;
            create_lbl.Text = "Value:";
            create_lbl.Visible = false;
            // 
            // create_btn
            // 
            create_btn.Location = new Point(324, 212);
            create_btn.Name = "create_btn";
            create_btn.Size = new Size(94, 29);
            create_btn.TabIndex = 6;
            create_btn.Text = "Create";
            create_btn.UseVisualStyleBackColor = true;
            create_btn.Visible = false;
            create_btn.Click += create_btn_Click;
            // 
            // read_txtbox
            // 
            read_txtbox.Location = new Point(312, 179);
            read_txtbox.Name = "read_txtbox";
            read_txtbox.Size = new Size(125, 27);
            read_txtbox.TabIndex = 7;
            read_txtbox.Visible = false;
            // 
            // read_lbl
            // 
            read_lbl.AutoSize = true;
            read_lbl.Location = new Point(258, 182);
            read_lbl.Name = "read_lbl";
            read_lbl.Size = new Size(48, 20);
            read_lbl.TabIndex = 8;
            read_lbl.Text = "index:";
            read_lbl.Visible = false;
            read_lbl.Click += label1_Click;
            // 
            // read_indx_btn
            // 
            read_indx_btn.Location = new Point(324, 212);
            read_indx_btn.Name = "read_indx_btn";
            read_indx_btn.Size = new Size(94, 29);
            read_indx_btn.TabIndex = 9;
            read_indx_btn.Text = "READ";
            read_indx_btn.UseVisualStyleBackColor = true;
            read_indx_btn.Visible = false;
            read_indx_btn.Click += read_btn_Click;
            // 
            // read_indx
            // 
            read_indx.Location = new Point(40, 182);
            read_indx.Name = "read_indx";
            read_indx.Size = new Size(155, 29);
            read_indx.TabIndex = 10;
            read_indx.Text = "Read by index";
            read_indx.UseVisualStyleBackColor = true;
            read_indx.Visible = false;
            read_indx.Click += read_indx_Click;
            // 
            // read_list
            // 
            read_list.Location = new Point(40, 359);
            read_list.Name = "read_list";
            read_list.Size = new Size(155, 29);
            read_list.TabIndex = 11;
            read_list.Text = "Read the whole list";
            read_list.UseVisualStyleBackColor = true;
            read_list.Visible = false;
            read_list.Click += read_list_Click;
            // 
            // back
            // 
            back.Location = new Point(653, 490);
            back.Name = "back";
            back.Size = new Size(94, 29);
            back.TabIndex = 12;
            back.Text = "BACK";
            back.UseVisualStyleBackColor = true;
            back.Visible = false;
            back.Click += back_Click;
            // 
            // read_richTextBox
            // 
            read_richTextBox.Location = new Point(268, 225);
            read_richTextBox.Name = "read_richTextBox";
            read_richTextBox.Size = new Size(257, 197);
            read_richTextBox.TabIndex = 13;
            read_richTextBox.Text = "";
            read_richTextBox.Visible = false;
            // 
            // read_list_btn
            // 
            read_list_btn.Location = new Point(343, 444);
            read_list_btn.Name = "read_list_btn";
            read_list_btn.Size = new Size(94, 29);
            read_list_btn.TabIndex = 14;
            read_list_btn.Text = "READ";
            read_list_btn.UseVisualStyleBackColor = true;
            read_list_btn.Visible = false;
            read_list_btn.Click += read_list_btn_Click;
            // 
            // update_origin_lbl
            // 
            update_origin_lbl.AutoSize = true;
            update_origin_lbl.Location = new Point(207, 182);
            update_origin_lbl.Name = "update_origin_lbl";
            update_origin_lbl.Size = new Size(99, 20);
            update_origin_lbl.TabIndex = 15;
            update_origin_lbl.Text = "original value";
            update_origin_lbl.Visible = false;
            // 
            // update_txtBox_origin_value
            // 
            update_txtBox_origin_value.Location = new Point(312, 179);
            update_txtBox_origin_value.Name = "update_txtBox_origin_value";
            update_txtBox_origin_value.Size = new Size(125, 27);
            update_txtBox_origin_value.TabIndex = 16;
            update_txtBox_origin_value.Visible = false;
            // 
            // update_txtBox_new_value
            // 
            update_txtBox_new_value.Location = new Point(312, 225);
            update_txtBox_new_value.Name = "update_txtBox_new_value";
            update_txtBox_new_value.Size = new Size(125, 27);
            update_txtBox_new_value.TabIndex = 17;
            update_txtBox_new_value.Visible = false;
            // 
            // update_btn
            // 
            update_btn.Location = new Point(324, 269);
            update_btn.Name = "update_btn";
            update_btn.Size = new Size(94, 29);
            update_btn.TabIndex = 18;
            update_btn.Text = "Update";
            update_btn.UseVisualStyleBackColor = true;
            update_btn.Visible = false;
            update_btn.Click += update_btn_Click;
            // 
            // update_new_lbl
            // 
            update_new_lbl.AutoSize = true;
            update_new_lbl.Location = new Point(228, 228);
            update_new_lbl.Name = "update_new_lbl";
            update_new_lbl.Size = new Size(78, 20);
            update_new_lbl.TabIndex = 19;
            update_new_lbl.Text = "new value:";
            update_new_lbl.Visible = false;
            // 
            // delete_value_lbl
            // 
            delete_value_lbl.AutoSize = true;
            delete_value_lbl.Location = new Point(228, 182);
            delete_value_lbl.Name = "delete_value_lbl";
            delete_value_lbl.Size = new Size(48, 20);
            delete_value_lbl.TabIndex = 20;
            delete_value_lbl.Text = "Value:";
            delete_value_lbl.Visible = false;
            // 
            // delete_txtBox
            // 
            delete_txtBox.Location = new Point(312, 179);
            delete_txtBox.Name = "delete_txtBox";
            delete_txtBox.Size = new Size(125, 27);
            delete_txtBox.TabIndex = 21;
            delete_txtBox.Visible = false;
            // 
            // delete_btn
            // 
            delete_btn.Location = new Point(324, 212);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(94, 29);
            delete_btn.TabIndex = 22;
            delete_btn.Text = "Delete";
            delete_btn.UseVisualStyleBackColor = true;
            delete_btn.Visible = false;
            delete_btn.Click += delete_btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 558);
            Controls.Add(delete_btn);
            Controls.Add(delete_txtBox);
            Controls.Add(delete_value_lbl);
            Controls.Add(update_new_lbl);
            Controls.Add(update_btn);
            Controls.Add(update_txtBox_new_value);
            Controls.Add(update_txtBox_origin_value);
            Controls.Add(update_origin_lbl);
            Controls.Add(read_list_btn);
            Controls.Add(read_richTextBox);
            Controls.Add(back);
            Controls.Add(read_list);
            Controls.Add(read_indx);
            Controls.Add(read_indx_btn);
            Controls.Add(read_lbl);
            Controls.Add(read_txtbox);
            Controls.Add(create_btn);
            Controls.Add(create_lbl);
            Controls.Add(create_txtbox);
            Controls.Add(delete);
            Controls.Add(update);
            Controls.Add(read);
            Controls.Add(create);
            Name = "Form1";
            Text = "CRUD Application";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button create;
        private Button read;
        private Button update;
        private Button delete;
        private TextBox create_txtbox;
        private Label create_lbl;
        private Button create_btn;
        private TextBox read_txtbox;
        private Label read_lbl;
        private Button read_indx_btn;
        private Button read_indx;
        private Button read_list;
        private Button back;
        private RichTextBox read_richTextBox;
        private Button read_list_btn;
        private Label update_origin_lbl;
        private TextBox update_txtBox_origin_value;
        private TextBox update_txtBox_new_value;
        private Button update_btn;
        private Label update_new_lbl;
        private Label delete_value_lbl;
        private TextBox delete_txtBox;
        private Button delete_btn;
    }
}