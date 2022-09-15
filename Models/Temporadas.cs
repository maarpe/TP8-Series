namespace TP8_Series
{
    public class Temporadas
    {
        private int _idTemporada;
        private int _idSerie;
        private int _numTemporada;
        private string _tituloTemporada;

        public Temporadas(int idTemporada, int idSerie, int numTemporada, string tituloTemporada)
        {
            _idTemporada = idTemporada;
            _idSerie = idSerie;
            _numTemporada = numTemporada;
            _tituloTemporada = tituloTemporada;
        }
        public Temporadas()
        {
            _idTemporada = 0;
            _idSerie = 0;
            _numTemporada = 0;
            _tituloTemporada = "";
        }

        public int idTemporada
        {
            get{return _idTemporada;}
            set{_idTemporada = value;}
        }

        public int idSerie
        {
            get{return _idSerie;}
            set{_idSerie = value;}
        }

        public int numTemporada
        {
            get{return _numTemporada;}
            set{_numTemporada = value;}
        }

        public string tituloTemporada
        {
            get{return _tituloTemporada;}
            set{_tituloTemporada = value;}
        }

    }




















}