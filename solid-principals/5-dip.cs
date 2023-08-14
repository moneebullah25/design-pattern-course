using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid_principals
{
    class _5_dip
    {
        public class BusinessLogicLayer
        {
            private readonly DataAccessLayer DAL;

            public BusinessLogicLayer()
            {
                DAL = new DataAccessLayer();
            }

            public void Save(Object details)
            {
                DAL.Save(details);
            }
        }

        public class DataAccessLayer
        {
            public void Save(Object details)
            {
                //perform save
            }
        }





        // After Dependency Inversion Principal

        public class BusinessLogicLayerDIP
        {
            private readonly IRepositoryLayerDIP DAL;

            public BusinessLogicLayerDIP(IRepositoryLayerDIP repositoryLayer)
            {
                DAL = repositoryLayer;
            }

            public void Save(Object details)
            {
                DAL.Save(details);
            }
        }

        public interface IRepositoryLayerDIP
        {
            void Save(Object details);
        }

        public class DataAccessLayerDIP : IRepositoryLayerDIP
        {
            public void Save(Object details)
            {
                //perform save
            }
        }

    }
}
