namespace primeiro_projeto_estudos.Util
{
    public static class Utilidades
    {
        public static string SetarStatusTarefa(bool statusTarefa)
        {
            var concluida =  statusTarefa ? "Sim" : "Não";
            return concluida;
        }
    }
}