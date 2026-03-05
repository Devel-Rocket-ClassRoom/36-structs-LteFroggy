namespace Q3_2 {
    internal struct Score {
        public string Name;
        public int Kor;
        public int Eng;

        public int Total {
            get => Kor  + Eng;
        }
        public double Average {
            get => (double)Total / 2;
        }

        public Score(string name, int kor, int eng) : this() {
            Name = name;
            Kor = kor;
            Eng = eng;
        }

    }
}
