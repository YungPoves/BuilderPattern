namespace BuilderPattern
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
      textBox1 = new TextBox();
      btnCreate = new Button();
      lblNumberOfWalls = new Label();
      lblNumberOfDoors = new Label();
      lblNumberOfWindows = new Label();
      lblRoofStyle = new Label();
      lblHasGarage = new Label();
      numericUpDown1 = new NumericUpDown();
      numericUpDown2 = new NumericUpDown();
      numericUpDown3 = new NumericUpDown();
      comboBox1 = new ComboBox();
      comboBox2 = new ComboBox();
      ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
      ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
      ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
      SuspendLayout();
      // 
      // textBox1
      // 
      textBox1.Location = new Point(447, 12);
      textBox1.Multiline = true;
      textBox1.Name = "textBox1";
      textBox1.Size = new Size(341, 257);
      textBox1.TabIndex = 0;
      // 
      // btnCreate
      // 
      btnCreate.Location = new Point(548, 275);
      btnCreate.Name = "btnCreate";
      btnCreate.Size = new Size(157, 29);
      btnCreate.TabIndex = 1;
      btnCreate.Text = "Create";
      btnCreate.UseVisualStyleBackColor = true;
      btnCreate.Click += btnCreate_Click;
      // 
      // lblNumberOfWalls
      // 
      lblNumberOfWalls.AutoSize = true;
      lblNumberOfWalls.Font = new Font("Fira Code", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
      lblNumberOfWalls.Location = new Point(12, 12);
      lblNumberOfWalls.Name = "lblNumberOfWalls";
      lblNumberOfWalls.Size = new Size(218, 24);
      lblNumberOfWalls.TabIndex = 2;
      lblNumberOfWalls.Text = "Number of walls:";
      // 
      // lblNumberOfDoors
      // 
      lblNumberOfDoors.AutoSize = true;
      lblNumberOfDoors.Font = new Font("Fira Code", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
      lblNumberOfDoors.Location = new Point(12, 76);
      lblNumberOfDoors.Name = "lblNumberOfDoors";
      lblNumberOfDoors.Size = new Size(218, 24);
      lblNumberOfDoors.TabIndex = 3;
      lblNumberOfDoors.Text = "Number of doors:";
      // 
      // lblNumberOfWindows
      // 
      lblNumberOfWindows.AutoSize = true;
      lblNumberOfWindows.Font = new Font("Fira Code", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
      lblNumberOfWindows.Location = new Point(12, 131);
      lblNumberOfWindows.Name = "lblNumberOfWindows";
      lblNumberOfWindows.Size = new Size(244, 24);
      lblNumberOfWindows.TabIndex = 4;
      lblNumberOfWindows.Text = "Number of windows:";
      // 
      // lblRoofStyle
      // 
      lblRoofStyle.AutoSize = true;
      lblRoofStyle.Font = new Font("Fira Code", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
      lblRoofStyle.Location = new Point(12, 192);
      lblRoofStyle.Name = "lblRoofStyle";
      lblRoofStyle.Size = new Size(153, 24);
      lblRoofStyle.TabIndex = 5;
      lblRoofStyle.Text = "Roof style:";
      // 
      // lblHasGarage
      // 
      lblHasGarage.AutoSize = true;
      lblHasGarage.Font = new Font("Fira Code", 11.999999F, FontStyle.Bold, GraphicsUnit.Point, 0);
      lblHasGarage.Location = new Point(12, 246);
      lblHasGarage.Name = "lblHasGarage";
      lblHasGarage.Size = new Size(153, 24);
      lblHasGarage.TabIndex = 6;
      lblHasGarage.Text = "Has garage?";
      // 
      // numericUpDown1
      // 
      numericUpDown1.Location = new Point(262, 9);
      numericUpDown1.Name = "numericUpDown1";
      numericUpDown1.Size = new Size(150, 27);
      numericUpDown1.TabIndex = 7;
      // 
      // numericUpDown2
      // 
      numericUpDown2.Location = new Point(262, 73);
      numericUpDown2.Name = "numericUpDown2";
      numericUpDown2.Size = new Size(150, 27);
      numericUpDown2.TabIndex = 8;
      // 
      // numericUpDown3
      // 
      numericUpDown3.Location = new Point(262, 128);
      numericUpDown3.Name = "numericUpDown3";
      numericUpDown3.Size = new Size(150, 27);
      numericUpDown3.TabIndex = 9;
      // 
      // comboBox1
      // 
      comboBox1.FormattingEnabled = true;
      comboBox1.Location = new Point(261, 188);
      comboBox1.Name = "comboBox1";
      comboBox1.Size = new Size(151, 28);
      comboBox1.TabIndex = 10;
      // 
      // comboBox2
      // 
      comboBox2.FormattingEnabled = true;
      comboBox2.Location = new Point(261, 238);
      comboBox2.Name = "comboBox2";
      comboBox2.Size = new Size(151, 28);
      comboBox2.TabIndex = 11;
      // 
      // Form1
      // 
      AutoScaleDimensions = new SizeF(8F, 20F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(800, 450);
      Controls.Add(comboBox2);
      Controls.Add(comboBox1);
      Controls.Add(numericUpDown3);
      Controls.Add(numericUpDown2);
      Controls.Add(numericUpDown1);
      Controls.Add(lblHasGarage);
      Controls.Add(lblRoofStyle);
      Controls.Add(lblNumberOfWindows);
      Controls.Add(lblNumberOfDoors);
      Controls.Add(lblNumberOfWalls);
      Controls.Add(btnCreate);
      Controls.Add(textBox1);
      Name = "Form1";
      Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
      ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
      ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    internal TextBox textBox1;
    private Button btnCreate;
    private Label lblNumberOfWalls;
    private Label lblNumberOfDoors;
    private Label lblNumberOfWindows;
    private Label lblRoofStyle;
    private Label lblHasGarage;
    private NumericUpDown numericUpDown1;
    private NumericUpDown numericUpDown2;
    private NumericUpDown numericUpDown3;
    private ComboBox comboBox1;
    private ComboBox comboBox2;
  }
}
