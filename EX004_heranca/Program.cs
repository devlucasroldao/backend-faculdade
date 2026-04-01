using EX004_heranca;

/* PessoaFisica pessoaFisica = new PessoaFisica();

pessoaFisica.nome = "Lucas";
pessoaFisica.endereco = "Vila das Flores - AS";
pessoaFisica.cpf = "0000000";

PessoaJuridica pessoaJuridica = new PessoaJuridica();

pessoaJuridica.nome = "Perfumes";
pessoaJuridica.endereco = "Av. Assis Brasil - SP";
pessoaJuridica.cnpj = "99999";

Conta conta = new Conta();
conta.AbrirConta(pessoaFisica);
conta.AbrirConta(pessoaJuridica); */

Pessoa pessoa = new Pessoa();
pessoa.nome = "Lucas";
pessoa.endereco = "Rua das flores - RS";

PessoaFisica pessoaFisica = new PessoaFisica();
pessoaFisica.cpf = "1234567890";

PessoaFisica pessoaJuridica = new PessoaFisica();
pessoaJuridica.cpf = "1234567890";

Conta conta = new Conta();
conta.AbrirConta(pessoa);
