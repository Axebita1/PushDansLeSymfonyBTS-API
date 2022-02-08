﻿namespace PushDansMaster
{
    public class PanierGlobal
    {
        private int ID;
        private int status;
        private int semaine;

        #region Getters / Setters

        /// <summary>
        /// Permet d'obtenir le status
        /// </summary>
        public int getStatus
        {
            get { return status; }
            private set { status = value; }
        }

        public int getSemaine
        {
            get { return semaine; }
            private set { semaine = value; }
        }

        public int getID
        {
            get { return ID; }
            private set { ID = value; }
        }
        #endregion

        #region Constructeurs

        public PanierGlobal(int status, int semaine)
        {
            this.status = status;
            this.semaine = semaine;
        }

        public PanierGlobal(int id, int status, int semaine)
            : this(status, semaine)
        {
            this.ID = id;
        }

        public PanierGlobal()
        {

        }

        #endregion
    }
}