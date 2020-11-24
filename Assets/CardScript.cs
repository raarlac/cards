using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; using TMPro;

public class CardScript : MonoBehaviour
{
    [SerializeField] GameObject cardTemplate;
    GameObject currentCard;
    [SerializeField] TextAsset text;
    string[] linesInFile;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        int i = 0;
        yield return new WaitForSeconds(1f);
        while (i<10)
        {
            yield return new WaitForSeconds(0.1f);
            currentCard = Instantiate(cardTemplate);
            i++;
        }
        linesInFile = new string[] { "Os principais biomas brasileiros são:\n\na) Amazônia, Cerrado, Mata Atlântica, Pampas, Caatinga e Pantanal.\nb) Mata de Galeria, Cerrado, Amazônia, Pantanal e Igapó.\nc) Biomas costeiros, Campos, Pampas, Pradarias e Mata Atlântica.\nd) Manguezal, Pradarias, Amazônia, Caatinga, Cerradão e Campo sujo.\n\nAlternativa correta: A "
            ,"O clima que caracteriza o Cerrado é:\n\na) Clima Equatorial.\nb) Clima Tropical de Altitude.\nc) Tropical Continental.\nd) Tropical Úmido\n\nAlternativa correta: C "
            ,"A Mata Atlântica é um importante bioma brasileiro que, em virtude da intensa exploração, praticamente não existe mais. Esse bioma enquadra-se em que tipo de bioma mundial?\na) Savanas.\nb) Floresta Equatorial.\nc) Campos.\n e) Floresta Tropical.\n\n Alternativa correta: E "
            ,"Todos os dias, o lixo é produzido em todas as cidades. Existem formas mais adequadas para o encaminhamento desses resíduos. Isso trará benefício econômico e ambiental. Por exemplo, restos de alimentos, lixo hospitalar e resíduos sólidos devem ser encaminhados, respectivamente, para:\nA) usina de compostagem, incineração e reciclagem.\nB) usina de compostagem, aterro sanitário e reciclagem\nC) incineração, incineração e lixão.\n\nAlternativa correta: A"
            ," A ação que melhor representa o aproveitamento do lixo é:\na) economizar água.\nb) realizar a coleta seletiva para reciclagem.\nc) evitar o desperdício de energia elétrica.\nd) fazer o plantio de novas mudas.\n\nAlternativa correta: B"
            ,"De origem bastante discutida, essa formação é característica das áreas onde o clima apresenta duas estações bem marcadas: uma seca e outra chuvosa, como no Planalto Central. Ela apresenta dois estratos nítidos: um arbóreo-arbustivo, no qual as espécies tortuosas têm os caules geralmente revestidos de casca espessa, e outro herbáceo, geralmente disposto em tufos.\na)Cerrado.\nb)Floresta tropical.\nc) Formação do Pantanal.\n\nAlternativa correta: A"
            ,"O Cerrado é um dos biomas brasileiros mais ameaçados diante da sua biodiversidade e está presente também no estado de Goiás. A ameaça desse bioma deve-se\na) à profundidade do solo e à pouca quantidade de nutrientes nele existente.\nb) às estações do ano bem definidas, sendo seca e chuvosa.\nd) às atividades humanas ligadas à agricultura e à pecuária.\n\nAlternativa correta: D"
            ,"A Floresta Amazônica está presente em região do Brasil? ACERTOU ANDE 7 CASAS. ERROU VOLTE 7\na) Região Norte\nb) Região Sul\nc) Região Leste\nd) Região Oeste\n\nAlternativa Correta: A"
            ,"As bacias hidrográficas no Brasil com maior potencial para a navegação são:\na) Amazônica e do Paraguai\nb) São Francisco e Paraná\nc) Amazônica e do São Francisco\nd) Uruguai e Paraguai\n\nAlternativa Correta: A"
            ,"O Pantanal é um tipo de bioma que é conhecido por ser uma das maiores planícies inundáveis do planeta. Quais estados compõem este BIOMA? ACERTOU AVANCE 3 CASAS. ERROU NÃO AVANCE.\na) Goiás e Mato Grosso\nb) Bahia e Minas Gerais\nc) Pará e Amazonas\nd) Mato Grosso e Mato Grosso do Sul\ne) Rio Grande do Sul e Santa Catarina\n\nAlternativa correta: D"
            ,"Além do Brasil, o Pantanal também está presente em outros dois países sul-americanos. qual alternativa é a certa? ACERTOU AVANCE 4 CASAS. ERROU RECUE\na) Argentina e Paraguai\nb) Bolívia e Peru\nc) Paraguai e Bolívia\nd) Argentina e Uruguai\n\nAlternativa correta: C"
            ,"Qual é o nome da ave símbolo do pantanal? ACERTOU AVANCE 4 CASAS. ERROU RECUE  2 CASAS.\n\na) Tuiuiú\nb) Jacaré do Pantanal \nc) Onça Pintada\nd) Capivara\n\nAlternativa correta: A"
            ,"A grande extensão territorial do Brasil proporciona ao país, fronteira com quase todas as nações sul-americanas. Os dois países que não se limitam com o Brasil são:\n\na) Uruguai e Peru\nb) Chile e Equador\nc) Bolívia e Venezuela\nd) Argentina e Chile\ne) Peru e Colômbia\n\nAlternativa correta: B"
            ,"Além do Brasil, o Pantanal também está presente em outros dois países sul-americanos. qual alternativa é a certa? ACERTOU AVANCE 4 CASAS. ERROU RECUE\n a) Argentina e Paraguai\n\nb) Bolívia e Peru\nc) Paraguai e Bolívia\nd) Argentina e Uruguai\n\nAlternativa correta: C"
            ,"Qual das árvores abaixo fazem parte da flora da caatinga? ACERTOU AVANCE 4 CASAS. ERROU RECUE 2 CASAS.\n\na) Pau Brasil\nb) Xicória\nc) Cacto\nd) Lírio\n\nAlternativa correta: C"
            ,"Qual dessas árvores fazem parte da flora da mata atlântica? ACERTOU AVANCE 6 CASAS. ERROU RECUE 2 CASAS.\n\na) Pau Brasil\nb) Xicória\nc) Cacto\nd) Lírio\n\nAlternativa correta: C"
            ,"Quantos estados brasileiros estão presentes na mata atlântica? ACERTOU AVANCE 3 CASAS. ERROU RECUE 4 CASAS\n\na) 10\nb) 17\nc) 41\nd) 7\n\nAlternativa correta: B"
            ,"Quais são os principais animais presentes na mata atlântica? ACERTOU AVANCE 3 CASAS. ERROU RECUE 3 CASAS\n\na) Arara-Azul, Capivara, Lobo Guará\nb) Mico-leão-dourado, Bicho preguiça, cachorro-do-mato.\nc) Leão, Onça pintada, Pantera Negra\nd) Jararaca, Crocodilo, Tuiuiú.\n\nAlternativa correta: B"
            ,"Qual é o clima predominante na mata atlântica? ACERTOU AVANCE 4 CASAS. ERROU RECUE 1 CASAS\n\na) Tropical úmido\nb) Quente e seco\nc) Quente e úmido\nd) Chuvoso e árido\n\nAlternativa correta: A"
            ,"Em qual região do Brasil fica localizado o pampa? ACERTOU AVANCE 2 CASAS. ERROU NÃO AVANCE.\n\na) Norte\nb) Sul\nc) Leste\nd) Oeste\n\nAlternativa correta: B"
            ,"Quais desses animais são típicos do Pampa? ACERTOU AVANCE 2 CASAS. ERROU NÃO AVANCE.\n\na) Tammandua e Onça pintada\nb) Jacaré do pantanal e Beija-flor\nc) Jararaca e Arara azul\nd) Macaco prego e Tigure branco\n\nAlternativa correta: A"
            ,"A Mata dos Cocais está presente em três estados do Brasil. Marque a alternativa que indica corretamente essas três unidades federativas que abrigam esse tipo de vegetação\n\na) Goiás, Mato Grosso e Mato Grosso do Sul\nb) Rio Grande do Sul, Santa Catarina e Paraná\nc) Amazonas, Pará e Roraima\nd) Rio de Janeiro, Espírito Santo e São Paulo\ne) Maranhão, Piauí e Tocantins\n\nAlternativa correta: A"
            ,"É um bioma caracterizado por ser uma área de transição entre as florestas úmidas da bacia Amazônica e as terras semiáridas do Nordeste brasileiro. Sua vegetação é formada principalmente por palmeiras, babaçu e carnaúba. Essas são características de qual bioma brasileiro? ACERTOU AVENCE 5 CASAS. ERROU FIQUE UMA RODADA SEM JOGAR\n\na) Cerrado\nb) Mata de Cocais\n\nAlternativa correta: B"
            ,"Em virtude dos contrastes naturais e socioeconômicos encontrados na região Nordeste, normalmente ela é dividida em:\n\na) Meio-norte, Caatinga, Zona da Mata e Agreste.\nb) Caatinga, Cerrado, Meio norte e Sertão.\nc) Semiárido, Meio-norte, Caatinga e Sertão.\nd) Semiárido, Caatinga, Zona da Mata e Agreste.\ne) Meio-norte, Sertão, Agreste e Zona da Mata\n\nAleternativa correta: E"
            ,"A grande extensão territorial do Brasil proporciona ao país, fronteira com quase todas as nações sul-americanas. Os dois países que não se limitam com o Brasil são:\n\na) Uruguai e Peru\nb) Chile e Equador\nc) Bolívia e Venezuela\nd) Argentina e Chile\ne) Peru e Colômbia\n\nAlternativa correta: B"
            ,"Em relação aos tipos de clima no Brasil, marque qual clima abrange uma porção maior do território e melhor caracteriza o país:\n\na) Clima Semiárido\nb) Clima Equatorial\nc) Clima Subtropical\nd) Clima Tropical\ne) Clima Desértico\n\nAlternativa correta: D"
            ,"Em relação aos tipos climáticos encontrados no Brasil, a afirmação errada é:\n\na) O clima equatorial apresenta elevados índices pluviométricos e temperaturas médias acima de 22 °C.\nb) O clima subtropical apresenta pequenas amplitudes térmicas e chuvas concentradas no verão.\n\nAlternativa correta: D"
            ,"O Pantanal é um tipo de bioma que se caracteriza por ser uma das maiores planícies inundáveis do planeta. Quais estados brasileiros que possuem esse bioma.\n\na) Goiás e Mato Grosso\nb) Bahia e Minas Gerais\nc) Pará e Amazonas\nd) Mato Grosso e Mato Grosso do Sul\ne) Rio Grande do Sul e Santa Catarina\n\nAlternativa correta: D"
            ,"O Pantanal é um tipo de bioma que se caracteriza por ser uma das maiores planícies inundáveis do planeta. Quais estados brasileiros que possuem esse bioma.\n\na) Goiás e Mato Grosso\nb) Bahia e Minas Gerais\nc) Pará e Amazonas\nd) Mato Grosso e Mato Grosso do Sul\ne) Rio Grande do Sul e Santa Catarina\n\nAlternativa correta: D"
            ,"Sobre o território brasileiro, qual alternativa está INCORRETA:\n\na) o Brasil é um país com dimensões continentais.\nb) a extensão do território brasileiro denuncia a grande distância de seus pontos extremos.\nc) a localização do Brasil indica-se por longitudes negativas, no hemisfério ocidental.\nd) a grande variação de latitudes explica a homogeneidade climática do país.\n\nAlternativa correta: D"




       };
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            currentCard.GetComponent<Animator>().SetTrigger("turn");
            currentCard.GetComponentInChildren<TextMeshProUGUI>().text = linesInFile[0];
        }
    }
}
