#include <iostream>
#include <fstream>

enum token {
    INT_LIT,
    IDENT
};

enum token int_lit (void) {
    char c = getchar();
    while (isdigit(c)) {
        c = getchar();
    }

    return INT_LIT;
}

enum token ident () {
    char c = getchar();
    while (isdigit(c)) {
        c = getchar();
    }

    return IDENT;
}


int main (void) {
    std::string str;
    std::ifstream file("testfile.iye");

    while (!file.eof()) {
        
    }

    // while (getline(file, str)) {
    //     for (char c : str) {
    //         std::string s(1, c);
    //         std::cout << s;
    //         if (isdigit(c)) {
    //             return int_lit();
    //         }
    //         else {
    //             continue;
    //         }
    //     }
    // }

    return 0;
}