using Refatoracao;

IImpressao _impressora = new Impressao();
IDigitalizacao _scanner = new Digitalizacao();
IFax _fax = new Fax();
IMultifuncional _multifuncional = new Multifuncional(); 

_impressora.Imprimir("Curriculo.docx");

_scanner.Digitalizar("Matéria Jornalística.");

_fax.EnviarFax("Dados Pessoais");

_multifuncional.Imprimir("Multi Curriculo.docx");
_multifuncional.Digitalizar("Multi Certidão Nascimento");
_multifuncional.EnviarFax("Multi Dados Pessoais");
_multifuncional.FazerCopias("Multi Folheto", 10);