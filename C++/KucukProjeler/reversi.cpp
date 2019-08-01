/*
 * File:   main.cpp
 * Author: aorhanocak
 *
 * Created on September 28, 2015, 9:33 PM
 */
 
#include <iostream>
#define SIZE 20
const char P1_DISC = 'O';
const char P2_DISC = 'X';
 
using namespace std;
 
int get_boardSize();
void generateBoard(char arr[][SIZE], int size);
void displayBoard(const char arr[][SIZE], int size);
void getMove_user(char disc, char arr[][SIZE], int size);
bool checkMove(char gameBoard[][SIZE], int row, int column, int size);
int performMove(char disc, char gameBoard[][SIZE], int row, int column, int size);
bool* witchDirection(char disc, const char gameBoard[][SIZE], int row, int column);
bool canPlay(char disc, const char gameBoard[][SIZE], int size);
void printScore(const char gameBoard[][SIZE], int size);
void calcBestMove(char disc, char gameBoard[][SIZE], int size, int info[]);
void getMove_AI(char disc, char gameBoard[][SIZE], int size);
 
int main(int argc, char** argv) {
 
 
    int size;
    char gameBoard[SIZE][SIZE];
 
    size = get_boardSize();
    generateBoard(gameBoard, size);
 
    while (1) {
        int count = 0;
        displayBoard(gameBoard, size);
        if (canPlay(P1_DISC, gameBoard, size) == true) {
            getMove_user(P1_DISC, gameBoard, size);
            count++;
        }
        if (canPlay(P2_DISC, gameBoard, size) == true) {
            getMove_AI(P2_DISC, gameBoard, size);
            count++;
        }
        if (count == 0)
            break;
    }
    displayBoard(gameBoard, size);
    printScore(gameBoard, size);
    return 0;
}
 
int get_boardSize() {
    int size;
    cout << "Enter the board size  8x8, 10x10... 20x20>\n";
    cin >> size;
 
    while ((size > 20 || size < 4) || (size % 2 != 0)) {
        cout << "Please enter a valid value>\n";
        cin >> size;
    }
    return size;
}
 
void generateBoard(char arr[][SIZE], int size) {
 
 
    for (int i = 0; i < size; i++) {
        for (int j = 0; j < size; j++) {
            arr[i][j] = '.';
        }
    }
 
    arr[size / 2 - 1 ][size / 2 - 1] = P2_DISC;
    arr[size / 2 - 1][size / 2] = P1_DISC;
    arr[size / 2][size / 2 - 1] = P1_DISC;
    arr[size / 2 ][size / 2 ] = P2_DISC;
}
 
void displayBoard(const char arr[][SIZE], int size) {
    for (int i = 0; i < size; i++) {
        cout << "________";
    }
    cout << endl << endl;
    cout << "\n\t";
    for (char k = 'a'; k < 'a' + size; k++) {
        cout << k << '\t';
    }
    cout << endl << endl << endl;
 
    for (int i = 0; i < size; i++) {
        cout << i << '\t';
        for (int j = 0; j < size; j++) {
            cout << arr[i][j] << "\t";
        }
        cout << endl;
        cout << endl;
        cout << endl;
    }
    for (int i = 0; i < size; i++) {
        cout << "________";
    }
    cout << endl << endl;
}
 
void getMove_user(char disc, char gameBoard[][SIZE], int size) {
    int row;
    int column;
    char move[2];
    cout << "your move>";
    cin >> move;
    column = move[0] - 'a';
    row = move[1] - '0';
    if (performMove(disc, gameBoard, row, column, size) <= 0) {
        cout << "your move was invalid please try again>>\n";
        getMove_user(disc, gameBoard, size);
    }
}
 
void calcBestMove(char disc, char gameBoard[][SIZE], int size, int info[]) {
    char tempBoard[size][SIZE];
    //char disc2 = P1_DISC;
    //if (disc == P1_DISC)
    //    disc2 = P2_DISC;
 
    for (int i = 0; i < size; i++) {
        for (int j = 0; j < size; j++) {
            tempBoard[i][j] = gameBoard[i][j];
        }
    }
    int curr_score;
    int max_score = 0;
 
 
    for (int row = 0; row < size; row++) {
        for (int column = 0; column < size; column++) {
            curr_score = performMove(disc, tempBoard, row, column, size);
            for (int i = 0; i < size; i++) {
                for (int j = 0; j < size; j++) {
                    tempBoard[i][j] = gameBoard[i][j];
                }
            }
 
            if (curr_score > max_score) {
                max_score = curr_score;
                info[0] = row;
                info[1] = column;
                info[2] = max_score;
            }
        }
    }
}
 
void getMove_AI(char disc, char gameBoard[][SIZE], int size) {
    cout << "AI thinking..." << endl;
    int info[3];
    calcBestMove(disc, gameBoard, size, info);
    performMove(disc, gameBoard, info[0], info[1], size);
    cout << char(info[1] + 'a') << info[0] << endl;
}
 
bool* witchDirection(char disc, const char gameBoard[][SIZE], int row, int column) {
    int total_directions = 8;
    bool directions[total_directions];
 
    for (int i = row - 1; i <= row + 1; i++) {
        for (int j = column - 1; j <= column + 1; j++) {
            if (gameBoard[i][j] != disc && gameBoard[i][j] != '.') {
                if (row - i == 1 && column - j == 0) {
                    //Up
                    directions[0] = true;
                }
                if (row - i == 1 && column - j == -1) {
                    //Up Right
                    directions[1] = true;
                }
                if (row - i == 0 && column - j == -1) {
                    //Right
                    directions[2] = true;
                }
                if (row - i == -1 && column - j == -1) {
                    //DownRight
                    directions[3] = true;
                }
                if (row - i == -1 && column - j == 0) {
                    //Down
                    directions[4] = true;
                }
                if (row - i == -1 && column - j == 1) {
                    //_DownLeft
                    directions[5] = true;
                }
                if (row - i == 0 && column - j == 1) {
                    //Left;
                    directions[6] = true;
                }
                if (row - i == 1 && column - j == 1) {
                    //UpLeft
                    directions[7] = true;
                }
            }
        }
    }
    return directions;
}
 
int performMove(char disc, char gameBoard[][SIZE], int row, int column, int size) {
    int counter = 0;
    if (
            row < size && column < size && gameBoard[row][column] == '.' &&
            (gameBoard[row + 1][column] != disc ||
            gameBoard[row + 1][column + 1] != disc ||
            gameBoard[row][column + 1] != disc ||
            gameBoard[row - 1][column + 1] != disc ||
            gameBoard[row - 1][column] != disc ||
            gameBoard[row ][column - 1] != disc ||
            gameBoard[row - 1][column - 1] != disc ||
            gameBoard[row + 1][column - 1] != disc)
            ) {
 
        bool* directions = witchDirection(disc, gameBoard, row, column);
        //up
        if (directions[0] == true) {
            for (int i = row - 1; i >= 0; i--) {
                if (gameBoard[i][column] == '.') {
                    break;
                } else if (gameBoard[i][column] == disc) {
                    for (int m = row - 1; m >= i; m--) {
                        gameBoard[m][column] = disc;
                        counter++;
                    }
                    break;
                }
            }
        }
        //up right
        if (directions[1] == true) {
            for (int i = row - 1, j = column + 1; i >= 0 && j < size; i--, j++) {
                if (gameBoard[i][j] == '.') {
                    break;
                } else if (gameBoard[i][j] == disc) {
                    for (int m = row - 1, k = column + 1; m >= i, k < j; m--, k++) {
                        gameBoard[m][k] = disc;
                        counter++;
                    }
                    break;
                }
            }
        }
        //right
        if (directions[2] == true) {
            for (int i = column + 1; i < size; i++) {
                if (gameBoard[row][i] == '.') {
                    break;
                } else if (gameBoard[row][i] == disc) {
                    for (int m = column + 1; m <= i; m++) {
                        gameBoard[row][m] = disc;
                        counter++;
                    }
                    break;
                }
            }
        }
        //down right
        if (directions[3] == true) {
            for (int i = row + 1, j = column + 1; i < size && j < size; i++, j++) {
                if (gameBoard[i][j] == '.') {
                    break;
                } else if (gameBoard[i][j] == disc) {
                    for (int m = row + 1, k = column + 1; m <= i && k <= j; m++, k++) {
                        gameBoard[m][k] = disc;
                        counter++;
                    }
                    break;
                }
            }
        }
 
        //down
        if (directions[4] == true) {
            for (int i = row + 1; i < size; i++) {
                if (gameBoard[i][column] == '.') {
                    break;
                } else if (gameBoard[i][column] == disc) {
                    for (int m = row + 1; m <= i; m++) {
                        gameBoard[m][column] = disc;
                        counter++;
                    }
                    break;
                }
            }
        }
        //down left
        if (directions[5] == true) {
            for (int i = row + 1, j = column - 1; i < size && j >= 0; i++, j--) {
                if (gameBoard[i][j] == '.') {
                    break;
                } else if (gameBoard[i][j] == disc) {
                    for (int m = row + 1, k = column - 1; m <= i && k >= j; m++, k--) {
                        gameBoard[m][k] = disc;
                        counter++;
                    }
                    break;
                }
            }
        }
 
 
        //left
        if (directions[6] == true) {
            for (int i = column - 1; i >= 0; i--) {
                if (gameBoard[row][i] == '.') {
                    break;
                } else if (gameBoard[row][i] == disc) {
                    for (int m = column - 1; m >= i; m--) {
                        gameBoard[row][m] = disc;
                        counter++;
                    }
                    break;
                }
            }
        }
 
        //up left
        if (directions[7] == true) {
            for (int i = row - 1, j = column - 1; i >= 0 && j >= 0; i--, j--) {
                if (gameBoard[i][j] == '.') {
                    break;
                } else if (gameBoard[i][j] == disc) {
                    for (int m = row - 1, k = column - 1; m >= i && k >= j; m--, k--) {
                        gameBoard[m][k] = disc;
                        counter++;
                    }
                    break;
                }
            }
        }
    }
    if (counter > 0)
        gameBoard[row][column] = disc;
    return counter;
}
 
bool canPlay(char disc, const char gameBoard[][SIZE], int size) {
    char tempBoard[size][SIZE];
    for (int i = 0; i < size; i++) {
        for (int j = 0; j < size; j++) {
            tempBoard[i][j] = gameBoard[i][j];
        }
    }
    for (int i = 0; i < size; i++) {
        for (int j = 0; j < size; j++) {
            if (performMove(disc, tempBoard, i, j, size) > 0)
                return true;
        }
    }
 
    return false;
}
 
void printScore(const char gameBoard[][SIZE], int size) {
    int counterP1 = 0;
    int counterP2 = 0;
    for (int i = 0; i < size; i++) {
        for (int j = 0; j < size; j++) {
            if (gameBoard[i][j] == P1_DISC)
                counterP1++;
            else if (gameBoard[i][j] == P2_DISC)
                counterP2++;
        }
    }
    if (counterP1 > counterP2)
        cout << "P1 wins!" << endl;
    else if (counterP2 > counterP1)
        cout << "P2 wins!" << endl;
    else
        cout << " draw!" << endl;
 
    cout << "Score P1:" << counterP1 << endl;
    cout << "Score P2:" << counterP2 << endl;
 
}
 
 
 

