using System.Windows.Forms;

public static class FormularioUtils
{
    public static void LimpiarControles(Control control)
    {
        foreach (Control c in control.Controls)
        {
            if (c is TextBox)
                ((TextBox)c).Clear();
            else if (c is ComboBox)
                ((ComboBox)c).SelectedIndex = -1;
            else if (c is CheckBox)
                ((CheckBox)c).Checked = false;
            else if (c is RadioButton)
                ((RadioButton)c).Checked = false;
            else if (c.HasChildren)
                LimpiarControles(c); // Recursivo para contenedores
        }
    }
}
