using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp54
{
    public class User:INotifyPropertyChanged
    {
		private string name;
		public string Name
		{
			get { return name; }
			set { name = value; OnPropertyChanged(); }
		}
		private string surname;

		public string Surname
		{
			get { return surname; }
			set { surname = value; OnPropertyChanged(); }
		}
		private int age;

		public int Age
		{
			get { return age; }
			set { age = value; OnPropertyChanged(); }
		}
		private int score;

		public int Score
		{
			get { return score; }
			set { score = value; OnPropertyChanged(); }
		}
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(name));
        }


    }
}
