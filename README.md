<h1>ProductCatalogApi</h1>
    <p>API básica com .NET Core e Clean Architecture.</p>

    <div class="section">
        <h2>Descrição</h2>
        <p>API RESTful simples para gerenciar um catálogo de produtos. A API permite operações de CRUD (Create, Read, Update, Delete) para produtos.</p>
        <p><strong>Obs:</strong> Produtos estáticos para teste.</p>
    </div>

    <div class="section">
        <h2>Tecnologias Utilizadas</h2>
        <ul>
            <li>.NET Core/C#</li>
        </ul>
    </div>

    <div class="section">
        <h2>Endpoints</h2>
        <ul>
            <li><code>GET /products</code> - Retorna a lista de produtos.</li>
            <li><code>GET /products/{id}</code> - Retorna um produto específico pelo ID.</li>
            <li><code>POST /products</code> - Cria um novo produto.</li>
            <li><code>PUT /products/{id}</code> - Atualiza um produto existente pelo ID.</li>
            <li><code>DELETE /products/{id}</code> - Deleta um produto pelo ID.</li>
        </ul>
    </div>

    <div class="section">
        <h2>Atributos do Produto</h2>
        <ul>
            <li><strong>Id</strong> (int)</li>
            <li><strong>Name</strong> (string)</li>
            <li><strong>Price</strong> (decimal)</li>
            <li><strong>Description</strong> (string)</li>
        </ul>
    </div>

    <div class="section">
        <h2>Execução da API</h2>
        <p>Para executar a API, basta rodar o projeto. Caso necessário, atualize os pacotes NuGet.</p>
    </div>

    <div class="section">
        <h2>Organização do Código</h2>
        <p>O código segue uma estrutura de Clean Architecture, garantindo clareza e organização.</p>
    </div>

    <div class="section">
        <h2>Boas Práticas</h2>
        <p>O projeto utiliza boas práticas de desenvolvimento, como Clean Architecture e padrões RESTful.</p>
    </div>
