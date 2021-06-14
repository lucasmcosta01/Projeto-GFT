using System;

namespace NetSeries
{
    public class Series: GeneralId
    {
       

        private string Title { get; set; }
        private Gender Gender { get; set; }
        private string Description { get; set; }
        private string Synopsis { get; set; }
        private TimeSpan Duration { get; set; }
        private int Age { get; set; }
        private bool Delete { get; set; }

        public Series (int id, string title, Gender gender, string description, TimeSpan duration, string synopsis, int age)
        {
            this.Id = id;
            this.Title = title;
            this.Gender = gender;
            this.Description = description;
            this.Synopsis = synopsis;
            this.Duration = duration;
            this.Age = age;
            this.Delete = false;
        }

       

        public override string ToString()
        {
            string show = "";
            show += "Title: " + this.Title + Environment.NewLine;
            show += "Gender: " + this.Gender + Environment.NewLine;
            show += "Description: " + this.Description + Environment.NewLine;
            show += "Synopsis: " + this.Synopsis + Environment.NewLine;
            show += "Duration: " + this.Duration + Environment.NewLine;
            show += "Ano: " + this.Age +Environment.NewLine;
            show += "Deleted: " + this.Delete;

            return show;
        }
        public string ReturnTitle()
        {
            return this.Title;
        }
        public int ReturnId()
        {
            return this.Id;
        }
        public bool ReturnDeleted()
        {
            return this.Delete;
        }
        public void Deleted()
        {
            this.Delete = true;

        }
        

    }
}
