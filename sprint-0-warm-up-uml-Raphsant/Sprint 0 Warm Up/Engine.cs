namespace Sprint_0_Warm_Up
{
    public class Engine
    {
        public bool isStarted;
        public string about;

        public Engine()
        {

        }

        public Engine(string about)
        {
            this.about = about;
        }

        public void Start()
        {
            isStarted = true;

        }

        public void Stop()
        {
            isStarted = false;
        }

        public string About()
        {
            if (isStarted == false) about = this + " engine is not started";

            else if (isStarted == true) about = this + " engine is started";

            return about;

        }




    }


}