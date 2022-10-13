int count = 0;
Console.Write("Введите расстояние между друзьями в метрах ");
int distance = int.Parse(Console.ReadLine());
Console.Write("Введите скорость первого друга в м/с ");
int first_friend_speed = int.Parse(Console.ReadLine());
Console.Write("Введите скорость второго друга в м/с ");
int second_friend_speed = int.Parse(Console.ReadLine());
Console.Write("Введите скорость собаки в м/с ");
int dog_speed = int.Parse(Console.ReadLine());
int friend = 2;
int time = 0;

while(distance > 10)
{
    if(friend == 1)
    {
        time = distance / (first_friend_speed + dog_speed);
        friend = 2;
    }
    
    else
    {
        time = distance / (second_friend_speed + dog_speed);
        friend = 1; 
    }

    distance = distance - (first_friend_speed + second_friend_speed) * time;
    count = count + 1;

}

    Console.WriteLine("Собака пробежит " + count + " раз");
