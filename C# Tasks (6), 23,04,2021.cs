    class Fraction
    {
        private double _deficitSpeed;
        private double _deficitDenominator;
    
    
        public Fraction(double deficitDenominator, double deficitSpeed)
        {
            _deficitDenominator = deficitDenominator;
            _deficitSpeed = deficitSpeed;
        }
    
    
        public static Fraction operator +(Fraction f, int i)
        {
            return new Fraction(f._deficitDenominator, (f._deficitDenominator * i) + f._deficitSpeed);
        }
    
        public static Fraction operator +(Fraction f, double i)
        {
            float onluq_kesir = (float)(f._deficitSpeed / f._deficitDenominator);
            float sum = (float)(onluq_kesir + i);
    
            string str = Convert.ToString(sum);
            string[] strs = str.Split('.');
    
            int tam_eded = Convert.ToInt32(strs[0]);
            int kesir_mexrec, kesir_suret;
    
            str = "1";
            for (int j = 0; j < strs[0].Length; j++) { str += "0"; }
    
            kesir_mexrec = Convert.ToInt32(str);
            kesir_suret = Convert.ToInt32(strs[1]);
    
            if (tam_eded == 0)
            {
                return new Fraction(kesir_mexrec, kesir_suret);
            }
            else
            {
                kesir_suret = (tam_eded * kesir_mexrec) + kesir_suret;
                return new Fraction(kesir_mexrec, kesir_suret);
            }
        }
    
        public static Fraction operator -(Fraction f, int i)
        {
            float onluq_kesir = (float)(f._deficitSpeed / f._deficitDenominator);
            float sum = (float)(onluq_kesir - i);
    
            string str = Convert.ToString(sum);
            string[] strs = str.Split('.');
    
            int tam_eded = Convert.ToInt32(strs[0]);
            int kesir_mexrec, kesir_suret;
    
            str = "1";
            for (int j = 0; j < strs[0].Length; j++) { str += "0"; }
    
            kesir_mexrec = Convert.ToInt32(str);
            kesir_suret = Convert.ToInt32(strs[1]);
    
            if (tam_eded == 0)
            {
                return new Fraction(kesir_mexrec, kesir_suret);
            }
            else
            {
                kesir_suret = (tam_eded * kesir_mexrec) + kesir_suret;
                return new Fraction(kesir_mexrec, kesir_suret);
            }
        }
    
        public static Fraction operator -(Fraction f, double i)
        {
            float onluq_kesir = (float)(f._deficitSpeed / f._deficitDenominator);
            float sum = (float)(onluq_kesir - i);
    
            string str = Convert.ToString(sum);
            string[] strs = str.Split('.');
    
            int tam_eded = Convert.ToInt32(strs[0]);
            int kesir_mexrec, kesir_suret;
    
            str = "1";
            for (int j = 0; j < strs[0].Length; j++) { str += "0"; }
    
            kesir_mexrec = Convert.ToInt32(str);
            kesir_suret = Convert.ToInt32(strs[1]);
    
            if (tam_eded == 0)
            {
                return new Fraction(kesir_mexrec, kesir_suret);
            }
            else
            {
                kesir_suret = (tam_eded * kesir_mexrec) + kesir_suret;
                return new Fraction(kesir_mexrec, kesir_suret);
            }
        }
    
        public static Fraction operator *(Fraction f, int i)
        {
            float onluq_kesir = (float)(f._deficitSpeed / f._deficitDenominator);
            decimal sum = (decimal)(onluq_kesir * i);
    
            string str = Convert.ToString(sum);
            string[] strs = new string[2];
            strs = str.Split('.');
    
            int tam_eded = Convert.ToInt32(strs[0]);
            int kesir_mexrec, kesir_suret;
    
            str = "1";
            for (int j = 0; j < strs[0].Length; j++) { str += "0"; }
    
            kesir_mexrec = Convert.ToInt32(str);
            kesir_suret = Convert.ToInt32(strs[1]);
    
            if (tam_eded == 0)
            {
                return new Fraction(kesir_mexrec, kesir_suret);
            }
            else
            {
                kesir_suret = (tam_eded * kesir_mexrec) + kesir_suret;
                return new Fraction(kesir_mexrec, kesir_suret);
            }
        }
    
        public static Fraction operator *(Fraction f, double i)
        {
            float onluq_kesir = (float)(f._deficitSpeed / f._deficitDenominator);
            decimal sum = (decimal)(onluq_kesir * i);
    
            string str = Convert.ToString(sum);
            string[] strs = str.Split('.');
    
            int tam_eded = Convert.ToInt32(strs[0]);
            int kesir_mexrec, kesir_suret;
    
            str = "1";
            for (int j = 0; j < strs[0].Length; j++) { str += "0"; }
    
            kesir_mexrec = Convert.ToInt32(str);
            kesir_suret = Convert.ToInt32(strs[1]);
    
            if (tam_eded == 0)
            {
                return new Fraction(kesir_mexrec, kesir_suret);
            }
            else
            {
                kesir_suret = (tam_eded * kesir_mexrec) + kesir_suret;
                return new Fraction(kesir_mexrec, kesir_suret);
            }
        }
    
        public static Fraction operator *(int i, Fraction f)
        {
            float onluq_kesir = (float)(f._deficitSpeed / f._deficitDenominator);
            decimal sum = (decimal)(onluq_kesir * i);
    
            string str = Convert.ToString(sum);
            string[] strs = str.Split('.');
    
            int tam_eded = Convert.ToInt32(strs[0]);
            int kesir_mexrec, kesir_suret;
    
            str = "1";
            for (int j = 0; j < strs[0].Length; j++) { str += "0"; }
    
            kesir_mexrec = Convert.ToInt32(str);
            kesir_suret = Convert.ToInt32(strs[1]);
    
            if (tam_eded == 0)
            {
                return new Fraction(kesir_mexrec, kesir_suret);
            }
            else
            {
                kesir_suret = (tam_eded * kesir_mexrec) + kesir_suret;
                return new Fraction(kesir_mexrec, kesir_suret);
            }
        }
    
        public static Fraction operator /(Fraction f, int i)
        {
            float onluq_kesir = (float)(f._deficitSpeed / f._deficitDenominator);
            decimal sum = (decimal)(onluq_kesir / i);
    
            string str = Convert.ToString(sum);
            string[] strs = str.Split('.');
    
            int tam_eded = Convert.ToInt32(strs[0]);
            int kesir_mexrec, kesir_suret;
    
            str = "1";
            for (int j = 0; j < strs[0].Length; j++) { str += "0"; }
    
            kesir_mexrec = Convert.ToInt32(str);
            kesir_suret = Convert.ToInt32(strs[1]);
    
            if (tam_eded == 0)
            {
                return new Fraction(kesir_mexrec, kesir_suret);
            }
            else
            {
                kesir_suret = (tam_eded * kesir_mexrec) + kesir_suret;
                return new Fraction(kesir_mexrec, kesir_suret);
            }
        }
    
        public static Fraction operator /(Fraction f, double i)
        {
            float onluq_kesir = (float)(f._deficitSpeed / f._deficitDenominator);
            decimal sum = (decimal)(onluq_kesir / i);
    
            string str = Convert.ToString(sum);
            string[] strs = str.Split('.');
    
            int tam_eded = Convert.ToInt32(strs[0]);
            int kesir_mexrec, kesir_suret;
    
            str = "1";
            for (int j = 0; j < strs[0].Length; j++) { str += "0"; }
    
            kesir_mexrec = Convert.ToInt32(str);
            kesir_suret = Convert.ToInt32(strs[1]);
    
            if (tam_eded == 0)
            {
                return new Fraction(kesir_mexrec, kesir_suret);
            }
            else
            {
                kesir_suret = (tam_eded * kesir_mexrec) + kesir_suret;
                return new Fraction(kesir_mexrec, kesir_suret);
            }
        }
    
        public static bool operator ==(Fraction f, bool i)
        {
            if (i == true)
            {
                if (f._deficitDenominator != 0 && f._deficitSpeed != 0) return true;
            }
            return false;
        }
    
        public static bool operator !=(Fraction f, bool i)
        {
            if (f._deficitDenominator != 0 && f._deficitSpeed != 0) return true;
            return false;
        }
    
        public static bool operator true(Fraction f)
        {
            if (f._deficitDenominator != 0 && f._deficitSpeed != 0) return true;
            return false;
        }
    
        public static bool operator false(Fraction f)
        {
            if (f._deficitDenominator != 0 && f._deficitSpeed != 0) return true;
            return false;
        }
    }