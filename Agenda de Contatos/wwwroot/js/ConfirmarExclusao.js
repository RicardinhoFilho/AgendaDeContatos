function ConfirmarExclusao(pessoaId, nomeContato) {
    $(".nomeContato").text(nomeContato)
    $(".modal").modal();

    $("btnExcluir").on("click", () => {
        $.ajax({
            url: "Pessoas/ExcluirPessoa",
            method: 'POST',
            data: { pessoaId },
            success: function (data) {
                location.reload(true);
            }
        })
    });

    $(".btnFechar").on("click", () => {
        pessoaId = null;
        nomeContato = null;
        $(".modal").modal('hide');
    });
}