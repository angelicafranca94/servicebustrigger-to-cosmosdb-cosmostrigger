# Monitoramento de dados via Azure Function #

<p>Aplicativo que escuta filas no Service Bus e armezena o conteúdo da fila no Cosmos DB na Azure. O armazenamento do documento ativa uma function CosmosTrigger e gera uma ação com os dados recuperados do documento. </p>
