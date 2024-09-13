//start main
string enjoymentLevel = GetEnjoymentLevel();
string stadium = GetStadiumRecommendation(enjoymentLevel);
string game = GetGameRecommendation(stadium);
DisplayStadiumDetails(stadium, game);
//end main

static string GetEnjoymentLevel(){
    Console.Clear();
    System.Console.WriteLine("Welcome to College Football Intro!");
    System.Console.WriteLine("What level of enjoyment would you like from the game? (Boring, Average, Fun, Epic)");
    string userInput = Console.ReadLine();
    return userInput;
}

static string GetStadiumRecommendation(string userInput){
    if(userInput == "Boring"){
        return "Neyland Stadium";
    }
    else if(userInput == "Average"){
        return "Jordan-Hare Stadium";
    }
    else if(userInput == "Fun"){
        return "Tiger Stadium";
    }
    else if(userInput == "Epic"){
        return "Saban Field at Bryant-Denny Stadium";
    }
    else{
        return "N/A";
    }
}

static string GetGameRecommendation(string stadium){
    if(stadium == "Neyland Stadium"){
        return "Tennessee vs Kent State";
    }
    else if(stadium == "Jordan-Hare Stadium"){
        return "Auburn vs Kentucky";
    }
    else if(stadium == "Tiger Stadium"){
        return "LSU vs Alabama";
    }
    else if(stadium == "Saban Field at Bryant-Denny Stadium"){
        return "Alabama vs Auburn";
    }
    else{
        return "N/A";
    }
}

static void DisplayStadiumDetails(string stadium, string game){
    System.Console.WriteLine($"\nI recommend going to {stadium} for the {game} game.");   
}