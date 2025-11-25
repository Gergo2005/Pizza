using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace PizzA
{
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			StringBuilder sb = new StringBuilder();

			// Tészta
			var teszta =
				(lbTesztak.SelectedItem as ListBoxItem)?.Content.ToString()
				?? "Nincs kiválasztva";

			// Méret
			var meret =
				(cbMeret.SelectedItem as ComboBoxItem)?.Content.ToString()
				?? "Nincs kiválasztva";

			// Feltétek
			var feltetek = new StringBuilder();
			if (chkSajt.IsChecked == true) feltetek.Append("Sajt, ");
			if (chkSonka.IsChecked == true) feltetek.Append("Sonka, ");
			if (chkGomba.IsChecked == true) feltetek.Append("Gomba, ");
			if (chkOliva.IsChecked == true) feltetek.Append("Olívabogyó, ");
			if (chkKukorica.IsChecked == true) feltetek.Append("Kukorica, ");

			string feltetSzoveg =
				feltetek.Length > 0 ? feltetek.ToString().TrimEnd(',', ' ')
				: "Nincs feltét";

			// Átvétel
			string atvetel =
				rbHazhoz.IsChecked == true ? "Házhozszállítás" :
				rbSzemelyes.IsChecked == true ? "Személyes átvétel" :
				"Nincs kiválasztva";

			// Üzenet
			sb.AppendLine("🍕 Pizza rendelés összegzése:");
			sb.AppendLine($"Tészta: {teszta}");
			sb.AppendLine($"Méret: {meret}");
			sb.AppendLine($"Feltétek: {feltetSzoveg}");
			sb.AppendLine($"Átvétel módja: {atvetel}");

			MessageBox.Show(sb.ToString(), "Rendelés");
		}
	}
}

