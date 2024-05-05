def mcd(a, b):
    while b != 0:
        a, b = b, a % b
    return a

def mcd_cuatro_numeros(a, b, c, d):
    temp = mcd(a, b)
    temp = mcd(temp, c)
    temp = mcd(temp, d)
    return temp

import unittest

class TestMCD(unittest.TestCase):
    def test_mcd(self):
        self.assertEqual(mcd(12, 8), 4)
        self.assertEqual(mcd(25, 15), 5)
        self.assertEqual(mcd(100, 75), 25)
    
    def test_mcd_cuatro_numeros(self):
        self.assertEqual(mcd_cuatro_numeros(12, 8, 16, 4), 4)
        self.assertEqual(mcd_cuatro_numeros(25, 15, 10, 5), 5)
        self.assertEqual(mcd_cuatro_numeros(100, 75, 50, 25), 25)

if __name__ == '__main__':
    unittest.main()
