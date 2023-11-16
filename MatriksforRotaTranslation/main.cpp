#include <iostream>
#include <cmath>

// Matris çarpımı fonksiyonu
void matrisCarpimi(double A[2][2], double B[2][2], double C[2][2]) {
    for (int i = 0; i < 2; ++i) {
        for (int j = 0; j < 2; ++j) {
            C[i][j] = 0;
            for (int k = 0; k < 2; ++k) {
                C[i][j] += A[i][k] * B[k][j];
            }
        }
    }
}

int main() {
    double A[2] = {6, 2};
    double B[2] = {9, 2};
    double C[2] = {6, 4};
    double P[2] = {10, 10};

    // Dönme açısı
    double theta = 70 * M_PI / 180; // Radyana çevirme

    // Dönüş matrisi
    double R[2][2] = {{cos(theta), -sin(theta)},
                      {sin(theta), cos(theta)}};

    // Öteleme vektörü
    double T[2] = {0, -12};

    // Dönme işlemi
    double A_prime[2], B_prime[2], C_prime[2], P_prime[2];

    matrisCarpimi(R, A, A_prime);
    matrisCarpimi(R, B, B_prime);
    matrisCarpimi(R, C, C_prime);
    matrisCarpimi(R, P, P_prime);

    // Öteleme işlemi
    A_prime[0] += T[0];
    A_prime[1] += T[1];
    B_prime[0] += T[0];
    B_prime[1] += T[1];
    C_prime[0] += T[0];
    C_prime[1] += T[1];
    P_prime[0] += T[0];
    P_prime[1] += T[1];

    // Çıktıları yazdırma
    std::cout << "Koordinat Eksenleri:\n";
    std::cout << "x ekseninde y +12 birim, y ekseninde x -6 birim hareketli" << std::endl;

    std::cout << "Cisim:\n";
    std::cout << "A(" << A_prime[0] << ", " << A_prime[1] << "), ";
    std::cout << "B(" << B_prime[0] << ", " << B_prime[1] << "), ";
    std::cout << "C(" << C_prime[0] << ", " << C_prime[1] << ")" << std::endl;

    std::cout << "P Noktası:\n";
    std::cout << "P(" << P_prime[0] << ", " << P_prime[1] << ")" << std::endl;

    std::cout << "Cismin Ötelendikten Sonra Döndürülmüş Hali:\n";
    std::cout << "A(" << A_prime[0] << ", " << A_prime[1] << "), ";
    std::cout << "B(" << B_prime[0] << ", " << B_prime[1] << "), ";
    std::cout << "C(" << C_prime[0] << ", " << C_prime[1] << "), ";
    std::cout << "P(" << P_prime[0] << ", " << P_prime[1] << ")" << std::endl;

    return 0;
}
