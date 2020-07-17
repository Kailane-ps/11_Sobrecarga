namespace _11_Sobrecarga
{
    public class Calcular
    {
         public string calculo(){
            return "Sem calculo";
        }
        public string calculo(string nome, string sobrenome){
            return $"O seu personagem é {nome} {sobrenome}";
        }

        public string calculo(string nome, int posicao){
            return $"{nome} esta em: {posicao} posição";
        }

        public string calculo(string nome,int posicao , int perda){
            return $"{nome} foi ultrapassado agora está em {posicao+perda} posição";
        }

        public string calculoo(string nome, float extra, int posicao){
            return $"{nome} pegou o Aku-Aku e esta em {posicao-extra} posição";
        }

    }
}