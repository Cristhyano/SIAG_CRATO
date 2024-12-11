﻿using System.ComponentModel.DataAnnotations.Schema;
using SIAG_CRATO.Data;

namespace SIAG_CRATO.Models;
public class ChamadaModel
{
    [Column("id_chamada")]
    public Guid Codigo { get; set; }

    [Column("id_palletorigem")]
    public int PalletOrigemId { get; set; }
    public PalletModel? PalletOrigem { get; set; }

    [Column("id_palletdestino")]
    public int PalletDestinoId { get; set; }
    public PalletModel? PalletDestino { get; set; }

    [Column("id_palletleitura")]
    public int PalletLeituraId { get; set; }
    public PalletModel? PalletLeitura { get; set; }

    [Column("id_areaarmazenagemorigem")]
    public int AreaArmazenagemOrigemId { get; set; }
    public AreaArmazenagemModel? AreaArmazenagemOrigem { get; set; }

    [Column("id_areaarmazenagemdestino")]
    public int AreaArmazenagemDestinoId { get; set; }
    public AreaArmazenagemModel? AreaArmazenagemDestino { get; set; }

    [Column("id_areaarmazenagemleitura")]
    public int AreaArmazenagemLeituraId { get; set; }
    public AreaArmazenagemModel? AreaArmazenagemLeitura { get; set; }

    [Column("id_operador")]
    public int OperadorId { get; set; }
    public OperadorModel? Operador { get; set; }

    [Column("id_equipamento")]
    public int EquipamentoId { get; set; }
    public EquipamentoModel? Equipamento { get; set; }

    [Column("id_atividaderejeicao")]
    public int AtividadeRejeicaoId { get; set; }
    public AtividadeRejeicaoModel? AtividadeRejeicao { get; set; }

    [Column("id_atividade")]
    public int AtividadeId { get; set; }
    public AtividadeModel? Atividade { get; set; }

    [Column("fg_status")]
    public StatusChamada Status { get; set; }

    [Column("dt_chamada")]
    public DateTime? DataChamada { get; set; }

    [Column("dt_recebida")]
    public DateTime? DataRecebida { get; set; }

    [Column("dt_atendida")]
    public DateTime? DataAtendida { get; set; }

    [Column("dt_finalizada")]
    public DateTime? DataFinalizada { get; set; }

    [Column("dt_rejeitada")]
    public DateTime? DataRejeitada { get; set; }

    [Column("DataSuspensa")]
    public DateTime? DataSuspensa { get; set; }

    [Column("id_chamadasuspensa")]
    public Guid CodigoChamadaSuspensa { get; set; }
}