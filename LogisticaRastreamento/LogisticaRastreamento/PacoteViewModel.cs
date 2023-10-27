using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpRastreamento.Models;
using System.ComponentModel;
using System.Runtime.CompilerServices;

//autores Diogo Teixeira e Rian Aquino
namespace TpRastreamento.ViewModels
{
    public class PacoteViewModel
    {

        private List<PacoteModel> _pacotes;

        public List<PacoteModel> Pacotes
        {
            get { return _pacotes; }
            set
            {
                _pacotes = value;
            }
        }

        public PacoteModel PacoteEncontrado { get; set; }

        public PacoteViewModel()
        {
            _pacotes = new List<PacoteModel>
            {
                new PacoteModel
                {
                    PacoteId = "1",
                    Status = "Em Preparo",
                    DataEnvio = DateTime.Now.AddDays(3),
                    DataPrevistaEntrega = DateTime.Now.AddDays(5),
                    HistoricoEventos = new List<string>
                    {
                        "Em preparo do fornecedor."
                    }
                },
                new PacoteModel
                {
                    PacoteId = "2",
                    Status = "Em trânsito para correios",
                    DataEnvio = DateTime.Now.AddDays(-1),
                    DataPrevistaEntrega = DateTime.Now.AddDays(5),
                    HistoricoEventos = new List<string>
                    {
                        "Em preparo do fornecedor",
                        "Em trânsito para correios"
                    }
                },
                new PacoteModel
                {
                    PacoteId = "3",
                    Status = "Em trânsito para consumidor",
                    DataEnvio = DateTime.Now.AddDays(-4),
                    DataPrevistaEntrega = DateTime.Now,
                    HistoricoEventos = new List<string>
                    {
                        "Em preparo do fornecedor",
                        "Em trânsito para correios",
                        "Pacote recebido nos correios.",
                        "Em trânsito para consumidor",
                    }
                },
                new PacoteModel
                {
                    PacoteId = "4",
                    Status = "Entregue para consumidor",
                    DataEnvio = DateTime.Now.AddDays(-4),
                    DataPrevistaEntrega = DateTime.Now,
                    HistoricoEventos = new List<string>
                    {
                        "Em preparo do fornecedor",
                        "Em trânsito para correios",
                        "Pacote recebido nos correios.",
                        "Em trânsito para consumidor",
                        "Pacote entregue ao consumidor"
                    }
                }
            };
        }

        public PacoteModel RastrearPacotePorCodigo(string codigoRastreamento)
        {
            PacoteEncontrado = _pacotes.Find(p => p.PacoteId == codigoRastreamento);

            if (PacoteEncontrado != null)
            {
                return PacoteEncontrado;
            }
            else
            {
                Application.Current.MainPage.DisplayAlert("Pacote não encontrado no sistema", "Verifique o código digitado está correto e tente novamente.", "Fechar");
                return null;
            }
        }

    }
}
