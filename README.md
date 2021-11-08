# Atomic Objects Programming Assessment
Programming assessment creating Othello Client AI


## My Command to start the server
```
java -jar othello.jar --p1-type random --p2-type remote --max-turn-time 30000 
```


## Example output when running my AI
```
C:\Users\User\Desktop\othello>java -jar othello.jar --p1-type random --p2-type remote --max-turn-time 30000
INFO  othello.server.http-server: Started othello http server on port: 8080
INFO  othello.server.text-ui: Player one | Starting...
INFO  othello.server.text-ui: Player two | Starting...
INFO  othello.server.text-ui: Player one | Idle...
INFO  othello.server.text-ui: Player two | Idle...
INFO  othello.server.text-ui: Player one | Connected...
INFO  othello.server.text-ui: Othello | Waiting for clients...
INFO  othello.server.player.remote: Listening for player two on port 1338
INFO  othello.server.text-ui: Player two | Connected...
INFO  othello.server.text-ui: Othello | Running...
INFO  othello.server.text-ui: Player one played: [2 4]
INFO  othello.server.text-ui: Player two played: [2 3]
INFO  othello.server.text-ui: Player one played: [5 2]
INFO  othello.server.text-ui: Player two played: [1 5]
INFO  othello.server.text-ui: Player one played: [3 2]
INFO  othello.server.text-ui: Player two played: [4 1]
INFO  othello.server.text-ui: Player one played: [1 3]
INFO  othello.server.text-ui: Player two played: [0 2]
INFO  othello.server.text-ui: Player one played: [2 5]
INFO  othello.server.text-ui: Player two played: [1 4]
INFO  othello.server.text-ui: Player one played: [0 3]
INFO  othello.server.text-ui: Player two played: [0 4]
INFO  othello.server.text-ui: Player one played: [2 1]
INFO  othello.server.text-ui: Player two played: [0 5]
INFO  othello.server.text-ui: Player one played: [0 6]
INFO  othello.server.text-ui: Player two played: [1 0]
INFO  othello.server.text-ui: Player one played: [1 2]
INFO  othello.server.text-ui: Player two played: [1 1]
INFO  othello.server.text-ui: Player one played: [3 0]
INFO  othello.server.text-ui: Player two played: [1 6]
INFO  othello.server.text-ui: Player one played: [3 1]
INFO  othello.server.text-ui: Player two played: [2 6]
INFO  othello.server.text-ui: Othello | Game over due to error...
INFO  othello.server.text-ui: Othello | Disconnecting players...
INFO  othello.server.text-ui: Player one | Disconnected...
INFO  othello.server.text-ui: Player two | Disconnected...
```

## Expected Outcome: 
I expected this program to play the first move available when it traverses the play board. The first 
sign of a true legal play will send out the move and play in the simplest of ways.

## Outcome: 
My program is not able to complete a full game. In some games it breaks after the first couple and 
others it will get in about 10-15 moves in and break due to an illegal move. 

# Experience:

### Overall:
I've enjoyed the learning experience. I have not worked with a server type project before in this 
type of way. It took me a while to digest the instructions of this assessment. I had to watch a few videos
on how to play othello as I've never learned the rules before this weekend. I spent a lot of time drawing 
out whatI wanted to create on mirrors and a white board; my white board wasnt big enough! After writing 
most of the code, my player got stuck on the first move. I spent an hour traversing the program looking for
the defect before reaching out to Dylan Goings. After speakihng with him and recieving his feedback, I was
able to get the program to play past the first move. I feel that with more time I would have the ability 
to debug and get the program to play the game to completion. 
