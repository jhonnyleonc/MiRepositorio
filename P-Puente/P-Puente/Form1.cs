using P_Puente.Bridge;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace P_Puente
{
    public partial class Form1 : Form
    {
        //private ComboBox comboBoxChurroType;
        //private ComboBox comboBoxChurroSize;
        //private NumericUpDown numericUpDownQuantity;

        public Form1()
        {
            InitializeComponent();
            //InitializeCustomComponents();
        }

        //private void InitializeCustomComponents()
        //{
        //    // Create and configure ComboBox for churro type
        //    comboBoxChurroType = new ComboBox
        //    {
        //        Location = new Point(20, 20),
        //        Size = new Size(200, 30),
        //        Items = { "Chocolate", "Strawberry" }
        //    };
        //    this.Controls.Add(comboBoxChurroType);

        //    // Create and configure ComboBox for churro size
        //    comboBoxChurroSize = new ComboBox
        //    {
        //        Location = new Point(20, 60),
        //        Size = new Size(200, 30),
        //        Items = { "Small", "Medium", "Large" }
        //    };
        //    this.Controls.Add(comboBoxChurroSize);

        //    // Create and configure NumericUpDown for quantity
        //    numericUpDownQuantity = new NumericUpDown
        //    {
        //        Location = new Point(20, 100),
        //        Size = new Size(200, 30),
        //        Minimum = 1,
        //        Maximum = 100
        //    };
        //    this.Controls.Add(numericUpDownQuantity);

        //    // Create and configure Button
        //    Button buttonShowChurros = new Button
        //    {
        //        Location = new Point(20, 140),
        //        Size = new Size(200, 30),
        //        Text = "Show Churros"
        //    };
        //    buttonShowChurros.Click += buttonShowChurros_Click;
        //    this.Controls.Add(buttonShowChurros);
        //}

        //private void buttonShowChurros_Click(object sender, EventArgs e)
        //{
        //    // Fetch user inputs
        //    string churroType = comboBoxChurroType.SelectedItem?.ToString() ?? "Not selected";
        //    string churroSize = comboBoxChurroSize.SelectedItem?.ToString() ?? "Not selected";
        //    int quantity = (int)numericUpDownQuantity.Value;

        //    // Display selected options
        //    string message = $"Churro Type: {churroType}\nChurro Size: {churroSize}\nQuantity: {quantity}";

        //    // Logic to process the inputs and display results
        //    // Modify this to use the inputs in your logic
        //    MessageBox.Show(message, "Churro Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //}

        //coment: ctrl+k ctrl +c
        //descome: ctrl+k ctrl+u

        //primera fase: visualizacion de ejemplo

        private void buttonShowChurros_Click(object sender, EventArgs e)
        {
            // Ejecutar el patrón de diseño y obtener resultados
            string results = MainBridge.ExecuteChurroPattern();

            // Mostrar resultados en un MessageBox
            MessageBox.Show(results, "Churro Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }





    }
}