namespace Pizza_Project
{
    partial class Menu
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
            this.gboxCrustType = new System.Windows.Forms.GroupBox();
            this.rdbCrustThin = new System.Windows.Forms.RadioButton();
            this.rdbCrustThink = new System.Windows.Forms.RadioButton();
            this.gboxToppings = new System.Windows.Forms.GroupBox();
            this.chkGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.chkExtraChess = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rdbtnSizeSmall = new System.Windows.Forms.RadioButton();
            this.gboxSize = new System.Windows.Forms.GroupBox();
            this.rdbtnSizeLarg = new System.Windows.Forms.RadioButton();
            this.rdbtnSizeMeduim = new System.Windows.Forms.RadioButton();
            this.gBoxWhere_to_eat = new System.Windows.Forms.GroupBox();
            this.btnDelivery = new System.Windows.Forms.Button();
            this.btnEatIn = new System.Windows.Forms.Button();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.gbOrderSummary = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            this.lbCrustType = new System.Windows.Forms.Label();
            this.lbToppings = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.gboxCrustType.SuspendLayout();
            this.gboxToppings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gboxSize.SuspendLayout();
            this.gBoxWhere_to_eat.SuspendLayout();
            this.gbOrderSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxCrustType
            // 
            this.gboxCrustType.Controls.Add(this.rdbCrustThin);
            this.gboxCrustType.Controls.Add(this.rdbCrustThink);
            this.gboxCrustType.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxCrustType.Location = new System.Drawing.Point(1, 257);
            this.gboxCrustType.Name = "gboxCrustType";
            this.gboxCrustType.Size = new System.Drawing.Size(176, 190);
            this.gboxCrustType.TabIndex = 3;
            this.gboxCrustType.TabStop = false;
            this.gboxCrustType.Text = "Crust Type";
            // 
            // rdbCrustThin
            // 
            this.rdbCrustThin.AutoSize = true;
            this.rdbCrustThin.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCrustThin.Location = new System.Drawing.Point(41, 57);
            this.rdbCrustThin.Name = "rdbCrustThin";
            this.rdbCrustThin.Size = new System.Drawing.Size(120, 27);
            this.rdbCrustThin.TabIndex = 7;
            this.rdbCrustThin.TabStop = true;
            this.rdbCrustThin.Tag = "0";
            this.rdbCrustThin.Text = "Thin Crust";
            this.rdbCrustThin.UseVisualStyleBackColor = true;
            this.rdbCrustThin.CheckedChanged += new System.EventHandler(this.rdbCrustThin_CheckedChanged);
            // 
            // rdbCrustThink
            // 
            this.rdbCrustThink.AutoSize = true;
            this.rdbCrustThink.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCrustThink.Location = new System.Drawing.Point(41, 130);
            this.rdbCrustThink.Name = "rdbCrustThink";
            this.rdbCrustThink.Size = new System.Drawing.Size(130, 27);
            this.rdbCrustThink.TabIndex = 6;
            this.rdbCrustThink.TabStop = true;
            this.rdbCrustThink.Tag = "10";
            this.rdbCrustThink.Text = "Think Crust";
            this.rdbCrustThink.UseVisualStyleBackColor = true;
            // 
            // gboxToppings
            // 
            this.gboxToppings.Controls.Add(this.chkGreenPeppers);
            this.gboxToppings.Controls.Add(this.chkMushrooms);
            this.gboxToppings.Controls.Add(this.chkOnion);
            this.gboxToppings.Controls.Add(this.chkOlives);
            this.gboxToppings.Controls.Add(this.chkTomatoes);
            this.gboxToppings.Controls.Add(this.chkExtraChess);
            this.gboxToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxToppings.Location = new System.Drawing.Point(183, 0);
            this.gboxToppings.Name = "gboxToppings";
            this.gboxToppings.Size = new System.Drawing.Size(268, 353);
            this.gboxToppings.TabIndex = 4;
            this.gboxToppings.TabStop = false;
            this.gboxToppings.Text = "Toppings";
            this.gboxToppings.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // chkGreenPeppers
            // 
            this.chkGreenPeppers.AutoSize = true;
            this.chkGreenPeppers.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGreenPeppers.Location = new System.Drawing.Point(39, 291);
            this.chkGreenPeppers.Name = "chkGreenPeppers";
            this.chkGreenPeppers.Size = new System.Drawing.Size(130, 23);
            this.chkGreenPeppers.TabIndex = 5;
            this.chkGreenPeppers.Tag = "5";
            this.chkGreenPeppers.Text = "Green Peppers";
            this.chkGreenPeppers.UseVisualStyleBackColor = true;
            this.chkGreenPeppers.CheckedChanged += new System.EventHandler(this.checkBox11_CheckedChanged);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMushrooms.Location = new System.Drawing.Point(39, 111);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(111, 23);
            this.chkMushrooms.TabIndex = 4;
            this.chkMushrooms.Tag = "2";
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOnion.Location = new System.Drawing.Point(39, 201);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(73, 23);
            this.chkOnion.TabIndex = 3;
            this.chkOnion.Tag = "5";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.checkBox9_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOlives.Location = new System.Drawing.Point(39, 246);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(71, 23);
            this.chkOlives.TabIndex = 2;
            this.chkOlives.Tag = "1";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTomatoes.Location = new System.Drawing.Point(39, 156);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(98, 23);
            this.chkTomatoes.TabIndex = 1;
            this.chkTomatoes.Tag = "2";
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // chkExtraChess
            // 
            this.chkExtraChess.AutoSize = true;
            this.chkExtraChess.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkExtraChess.Location = new System.Drawing.Point(39, 66);
            this.chkExtraChess.Name = "chkExtraChess";
            this.chkExtraChess.Size = new System.Drawing.Size(106, 23);
            this.chkExtraChess.TabIndex = 0;
            this.chkExtraChess.Tag = "2";
            this.chkExtraChess.Text = "Extra Chess";
            this.chkExtraChess.UseVisualStyleBackColor = true;
            this.chkExtraChess.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pizza_Project.Properties.Resources.wallpaperflare_com_wallpaper__3_;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(796, 447);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // rdbtnSizeSmall
            // 
            this.rdbtnSizeSmall.AutoSize = true;
            this.rdbtnSizeSmall.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnSizeSmall.Location = new System.Drawing.Point(11, 34);
            this.rdbtnSizeSmall.Name = "rdbtnSizeSmall";
            this.rdbtnSizeSmall.Size = new System.Drawing.Size(77, 27);
            this.rdbtnSizeSmall.TabIndex = 3;
            this.rdbtnSizeSmall.TabStop = true;
            this.rdbtnSizeSmall.Tag = "10";
            this.rdbtnSizeSmall.Text = "Small";
            this.rdbtnSizeSmall.UseVisualStyleBackColor = true;
            this.rdbtnSizeSmall.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // gboxSize
            // 
            this.gboxSize.Controls.Add(this.rdbtnSizeLarg);
            this.gboxSize.Controls.Add(this.rdbtnSizeMeduim);
            this.gboxSize.Controls.Add(this.rdbtnSizeSmall);
            this.gboxSize.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxSize.Location = new System.Drawing.Point(1, 0);
            this.gboxSize.Name = "gboxSize";
            this.gboxSize.Size = new System.Drawing.Size(176, 251);
            this.gboxSize.TabIndex = 2;
            this.gboxSize.TabStop = false;
            this.gboxSize.Text = "Size";
            // 
            // rdbtnSizeLarg
            // 
            this.rdbtnSizeLarg.AutoSize = true;
            this.rdbtnSizeLarg.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnSizeLarg.Location = new System.Drawing.Point(11, 156);
            this.rdbtnSizeLarg.Name = "rdbtnSizeLarg";
            this.rdbtnSizeLarg.Size = new System.Drawing.Size(70, 27);
            this.rdbtnSizeLarg.TabIndex = 5;
            this.rdbtnSizeLarg.TabStop = true;
            this.rdbtnSizeLarg.Tag = "20";
            this.rdbtnSizeLarg.Text = "Larg";
            this.rdbtnSizeLarg.UseVisualStyleBackColor = true;
            this.rdbtnSizeLarg.CheckedChanged += new System.EventHandler(this.rdbtnSizeLarg_CheckedChanged);
            // 
            // rdbtnSizeMeduim
            // 
            this.rdbtnSizeMeduim.AutoSize = true;
            this.rdbtnSizeMeduim.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnSizeMeduim.Location = new System.Drawing.Point(11, 101);
            this.rdbtnSizeMeduim.Name = "rdbtnSizeMeduim";
            this.rdbtnSizeMeduim.Size = new System.Drawing.Size(100, 27);
            this.rdbtnSizeMeduim.TabIndex = 4;
            this.rdbtnSizeMeduim.TabStop = true;
            this.rdbtnSizeMeduim.Tag = "15";
            this.rdbtnSizeMeduim.Text = "Meduim";
            this.rdbtnSizeMeduim.UseVisualStyleBackColor = true;
            this.rdbtnSizeMeduim.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // gBoxWhere_to_eat
            // 
            this.gBoxWhere_to_eat.Controls.Add(this.btnDelivery);
            this.gBoxWhere_to_eat.Controls.Add(this.btnEatIn);
            this.gBoxWhere_to_eat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxWhere_to_eat.Location = new System.Drawing.Point(183, 359);
            this.gBoxWhere_to_eat.Name = "gBoxWhere_to_eat";
            this.gBoxWhere_to_eat.Size = new System.Drawing.Size(323, 79);
            this.gBoxWhere_to_eat.TabIndex = 5;
            this.gBoxWhere_to_eat.TabStop = false;
            this.gBoxWhere_to_eat.Text = "Where To Eat";
            this.gBoxWhere_to_eat.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // btnDelivery
            // 
            this.btnDelivery.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelivery.Location = new System.Drawing.Point(210, 32);
            this.btnDelivery.Name = "btnDelivery";
            this.btnDelivery.Size = new System.Drawing.Size(102, 41);
            this.btnDelivery.TabIndex = 1;
            this.btnDelivery.Text = "delivery";
            this.btnDelivery.UseVisualStyleBackColor = true;
            this.btnDelivery.Click += new System.EventHandler(this.btnDelivery_Click);
            // 
            // btnEatIn
            // 
            this.btnEatIn.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEatIn.Location = new System.Drawing.Point(35, 32);
            this.btnEatIn.Name = "btnEatIn";
            this.btnEatIn.Size = new System.Drawing.Size(102, 41);
            this.btnEatIn.TabIndex = 0;
            this.btnEatIn.Text = "Eat In";
            this.btnEatIn.UseVisualStyleBackColor = true;
            this.btnEatIn.Click += new System.EventHandler(this.btnEatIn_Click);
            // 
            // btnResetForm
            // 
            this.btnResetForm.BackColor = System.Drawing.Color.Red;
            this.btnResetForm.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetForm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnResetForm.Location = new System.Drawing.Point(546, 406);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(112, 41);
            this.btnResetForm.TabIndex = 6;
            this.btnResetForm.Text = "Reset";
            this.btnResetForm.UseVisualStyleBackColor = false;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.Red;
            this.btnOrder.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOrder.Location = new System.Drawing.Point(685, 406);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(112, 41);
            this.btnOrder.TabIndex = 7;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // gbOrderSummary
            // 
            this.gbOrderSummary.Controls.Add(this.label4);
            this.gbOrderSummary.Controls.Add(this.label3);
            this.gbOrderSummary.Controls.Add(this.label2);
            this.gbOrderSummary.Controls.Add(this.label1);
            this.gbOrderSummary.Controls.Add(this.lbTotalPrice);
            this.gbOrderSummary.Controls.Add(this.lbCrustType);
            this.gbOrderSummary.Controls.Add(this.lbToppings);
            this.gbOrderSummary.Controls.Add(this.lbSize);
            this.gbOrderSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOrderSummary.Location = new System.Drawing.Point(457, 0);
            this.gbOrderSummary.Name = "gbOrderSummary";
            this.gbOrderSummary.Size = new System.Drawing.Size(340, 353);
            this.gbOrderSummary.TabIndex = 8;
            this.gbOrderSummary.TabStop = false;
            this.gbOrderSummary.Text = "Order Summary";
            this.gbOrderSummary.Enter += new System.EventHandler(this.gbOrderSummary_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total Price : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Crust Type : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Toppings : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Size : ";
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbTotalPrice.Location = new System.Drawing.Point(181, 301);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(43, 29);
            this.lbTotalPrice.TabIndex = 3;
            this.lbTotalPrice.Text = "0$";
            // 
            // lbCrustType
            // 
            this.lbCrustType.AutoSize = true;
            this.lbCrustType.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCrustType.Location = new System.Drawing.Point(147, 230);
            this.lbCrustType.Name = "lbCrustType";
            this.lbCrustType.Size = new System.Drawing.Size(99, 19);
            this.lbCrustType.TabIndex = 2;
            this.lbCrustType.Text = "Thin Crust";
            // 
            // lbToppings
            // 
            this.lbToppings.AutoSize = true;
            this.lbToppings.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbToppings.Location = new System.Drawing.Point(148, 91);
            this.lbToppings.Name = "lbToppings";
            this.lbToppings.Size = new System.Drawing.Size(96, 18);
            this.lbToppings.TabIndex = 1;
            this.lbToppings.Text = "No Toppings";
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSize.Location = new System.Drawing.Point(105, 42);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(63, 19);
            this.lbSize.TabIndex = 0;
            this.lbSize.Text = "Meduim";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 449);
            this.Controls.Add(this.gbOrderSummary);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.gBoxWhere_to_eat);
            this.Controls.Add(this.gboxToppings);
            this.Controls.Add(this.gboxCrustType);
            this.Controls.Add(this.gboxSize);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.gboxCrustType.ResumeLayout(false);
            this.gboxCrustType.PerformLayout();
            this.gboxToppings.ResumeLayout(false);
            this.gboxToppings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gboxSize.ResumeLayout(false);
            this.gboxSize.PerformLayout();
            this.gBoxWhere_to_eat.ResumeLayout(false);
            this.gbOrderSummary.ResumeLayout(false);
            this.gbOrderSummary.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gboxCrustType;
        private System.Windows.Forms.GroupBox gboxToppings;
        private System.Windows.Forms.CheckBox chkGreenPeppers;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.CheckBox chkExtraChess;
        private System.Windows.Forms.RadioButton rdbtnSizeSmall;
        private System.Windows.Forms.GroupBox gboxSize;
        private System.Windows.Forms.RadioButton rdbtnSizeLarg;
        private System.Windows.Forms.RadioButton rdbtnSizeMeduim;
        private System.Windows.Forms.RadioButton rdbCrustThin;
        private System.Windows.Forms.RadioButton rdbCrustThink;
        private System.Windows.Forms.GroupBox gBoxWhere_to_eat;
        private System.Windows.Forms.Button btnDelivery;
        private System.Windows.Forms.Button btnEatIn;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.GroupBox gbOrderSummary;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.Label lbCrustType;
        private System.Windows.Forms.Label lbToppings;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}