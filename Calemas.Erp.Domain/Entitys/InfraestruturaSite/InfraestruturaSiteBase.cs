using Common.Domain.Base;
using System;

namespace Calemas.Erp.Domain.Entitys
{
    public class InfraestruturaSiteBase : DomainBaseWithUserCreate
    {
        public InfraestruturaSiteBase()
        {

        }
        public InfraestruturaSiteBase(int infraestruturasiteid, string nome)
        {
            this.InfraestruturaSiteId = infraestruturasiteid;
            this.Nome = nome;

        }

        public virtual int InfraestruturaSiteId { get; protected set; }
        public virtual string Nome { get; protected set; }
        public virtual string Descricao { get; protected set; }
        public virtual string Latitude { get; protected set; }
        public virtual string Longitude { get; protected set; }
        public virtual string Endpoint { get; protected set; }
        public virtual string Login { get; protected set; }
        public virtual string Senha { get; protected set; }


		public virtual void SetarDescricao(string descricao)
		{
			this.Descricao = descricao;
		}
		public virtual void SetarLatitude(string latitude)
		{
			this.Latitude = latitude;
		}
		public virtual void SetarLongitude(string longitude)
		{
			this.Longitude = longitude;
		}
		public virtual void SetarEndpoint(string endpoint)
		{
			this.Endpoint = endpoint;
		}
		public virtual void SetarLogin(string login)
		{
			this.Login = login;
		}
		public virtual void SetarSenha(string senha)
		{
			this.Senha = senha;
		}


    }
}
