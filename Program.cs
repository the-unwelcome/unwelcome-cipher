using System;
using System.Text;


namespace testeeews
{
    public static class UNW5
    {
        static byte[] sbox1 =
        {
            0xa1,0x65,0x4c,0xe2,0x9d,0x2b,0x89,0x30,0xb8,0x56,0x79,0xdf,0xf2,0xdd,0x12,0x63,
            0xdb,0xa4,0xec,0x9c,0xb3,0x7c,0xd6,0x81,0x54,0xe7,0xe3,0xba,0x67,0x52,0xaa,0xeb,
            0x57,0x50,0x40,0x14,0x85,0x74,0x35,0xd0,0x8a,0x36,0x0c,0x71,0xab,0x32,0x90,0xaf,
            0x61,0xb6,0x2f,0xfd,0x4e,0xb9,0xfc,0x47,0xbd,0x7a,0x6f,0xe0,0xa7,0xd9,0xd7,0xc5,
            0x68,0x55,0x69,0xc0,0x96,0x19,0x5e,0x8e,0x7d,0x43,0x4a,0x58,0x93,0x6b,0x9a,0x8c,
            0x33,0xfb,0x9e,0x25,0x53,0x09,0x24,0x88,0xb7,0x5d,0xe9,0xa9,0x26,0xc1,0x76,0xd2,
            0xf4,0x38,0x27,0xf3,0xd1,0x59,0x97,0x60,0xbc,0x99,0x62,0x18,0xb0,0x49,0x2d,0xa2,
            0xae,0x41,0xa5,0x91,0x98,0xc4,0x7e,0x72,0x77,0x2a,0x4b,0x92,0x95,0x15,0xf7,0xc3,
            0x44,0x82,0x22,0xc9,0x46,0xa3,0xf1,0x66,0x5c,0xca,0x6a,0x51,0x83,0x5f,0x42,0x10,
            0x75,0x3d,0x0a,0x8f,0xa8,0x4f,0xac,0x3a,0x20,0x5b,0xf9,0x01,0x8d,0xb4,0x4d,0xf5,
            0x2c,0xb1,0x9f,0x23,0xb2,0x29,0xde,0xce,0xf8,0x0b,0xc2,0x87,0x37,0xcf,0x8b,0x03,
            0x00,0x1e,0x13,0x34,0xa0,0x1a,0xda,0x86,0x45,0x11,0xee,0xef,0xa6,0xd8,0xc7,0x3e,
            0x39,0x3c,0x48,0x07,0xd4,0x04,0xe4,0xc8,0x0f,0x2e,0xe8,0x6d,0x31,0xbe,0xb5,0xcc,
            0x1d,0x05,0x1f,0x1c,0xbb,0xea,0x80,0xdc,0x16,0x3b,0xc6,0xf6,0x17,0x5a,0x0e,0xe5,
            0x1b,0xcd,0x28,0x9b,0x06,0xcb,0xbf,0x02,0x21,0xad,0xfe,0xff,0x84,0x7f,0x3f,0x73,
            0x78,0xd5,0x6c,0xed,0x94,0x64,0x0d,0x6e,0xf0,0xfa,0xd3,0x7b,0xe6,0x70,0x08,0xe1
        };
        static byte[] sbox2 =
        {
            0xb8,0x7a,0x98,0x95,0x1e,0x07,0xff,0x7b,0x6c,0x10,0x5d,0x9b,0x1c,0x58,0x50,0x6a,
            0x7f,0x7c,0x15,0xdb,0x42,0x89,0x65,0x74,0x99,0xba,0x52,0x62,0x44,0x71,0x5b,0x94,
            0xca,0x60,0x0f,0xcd,0x9e,0x4e,0xf9,0xac,0x45,0x23,0x8a,0x40,0xa3,0x93,0x97,0x4d,
            0x57,0xf1,0x9a,0x6f,0xb7,0x33,0x5f,0xd7,0x8e,0xf2,0xe7,0xd2,0xee,0xf8,0x70,0x4a,
            0xfd,0xaa,0x29,0xa5,0xde,0xe2,0x13,0xe0,0xc8,0xb9,0xc9,0x8f,0x90,0x77,0x8d,0x7e,
            0xda,0xef,0x16,0x83,0x02,0xfe,0x82,0x38,0xab,0x3f,0xa2,0x53,0xf0,0x4f,0x18,0xc1,
            0xc0,0x6d,0x67,0x88,0x35,0x56,0x0e,0xfc,0xbd,0xf3,0x09,0x41,0x86,0xe4,0x81,0x55,
            0x48,0x72,0x4b,0x0c,0x59,0xd3,0x5c,0x8b,0x6b,0x49,0x2c,0x17,0xcc,0x9c,0x5e,0x84,
            0xb2,0x73,0x85,0xe6,0x5a,0x7d,0xbe,0x61,0xbb,0x05,0x3c,0x75,0x54,0xeb,0xb6,0xbc,
            0x1f,0x43,0x6e,0xea,0x63,0x96,0xb3,0x51,0x9f,0x3d,0xcb,0x1b,0xc2,0x32,0x27,0xce,
            0xae,0xfb,0xec,0xdf,0xaf,0x79,0xa0,0xdd,0xa4,0xf6,0x80,0xd0,0x46,0x04,0xfa,0xb5,
            0xe5,0x1d,0xcf,0xc3,0x11,0xb4,0xc4,0xbf,0x24,0xa6,0x66,0x8c,0x12,0x2e,0x2d,0xc7,
            0x68,0x76,0xdc,0x31,0xc5,0xc6,0x00,0xf7,0xa9,0xd4,0x3a,0xa7,0x19,0x34,0x2b,0x30,
            0x2a,0x0a,0xe3,0xed,0xd8,0x25,0x20,0x3e,0x3b,0x26,0xd5,0x69,0x21,0x22,0x91,0xad,
            0x36,0xd6,0xa1,0x47,0xd1,0x06,0x0b,0x87,0x1a,0x28,0x01,0xf5,0x78,0x37,0x64,0x08,
            0x2f,0x03,0x92,0xd9,0x14,0x0d,0xb1,0xe9,0x39,0x9d,0xf4,0xb0,0xe1,0x4c,0xa8,0xe8
        };
        static byte[] sbox3 = {
            0xc8,0x8f,0x5f,0xde,0xf7,0xcf,0xdd,0xc2,0x5d,0xcb,0x78,0x2f,0xb5,0x5b,0xed,0x7f,
            0x45,0x9f,0xb6,0x2d,0x72,0xfd,0xbf,0xec,0xa4,0xfa,0xa3,0xbb,0x80,0xa9,0xfc,0x8d,
            0x91,0xab,0x69,0x17,0x27,0xcc,0x15,0x3e,0x49,0xf0,0x96,0x8b,0x0c,0x94,0x7b,0x1c,
            0xdb,0x51,0x95,0xc1,0xc3,0x40,0x4f,0x36,0xb1,0x62,0x59,0xad,0x4a,0x29,0x26,0xa6,
            0x8c,0x99,0x42,0x97,0x28,0x82,0x70,0x81,0x37,0xbd,0x2c,0xc0,0xd3,0x14,0x47,0xfe,
            0xd2,0xeb,0x07,0xd7,0x3d,0xe9,0x32,0xf9,0x4c,0x16,0xb3,0x9e,0xce,0x8e,0x30,0xd9,
            0x7a,0xc6,0x1d,0x83,0x67,0x13,0x66,0xf2,0x76,0xf1,0x39,0xd0,0xe7,0x98,0xbe,0xdf,
            0x53,0x89,0x21,0x05,0x6a,0x7c,0x7e,0x4b,0xef,0x31,0x00,0x10,0xa0,0x22,0x6f,0x86,
            0x4d,0x1a,0x64,0x85,0x04,0x84,0x5a,0x08,0xaf,0xa7,0xff,0x61,0x1e,0x0b,0x63,0xd4,
            0x56,0xb0,0x24,0x6d,0xc4,0xcd,0x4e,0xb8,0xe2,0x12,0xa2,0xe5,0x0e,0x9d,0xba,0xd6,
            0x88,0x02,0x0d,0xee,0x55,0xf4,0xa1,0x19,0x41,0x77,0xf6,0x0a,0x34,0xdc,0x1f,0xbc,
            0x92,0x7d,0x48,0xc9,0x25,0x6e,0x44,0x5e,0xf3,0x3c,0xb7,0x57,0x2b,0x3b,0xea,0x0f,
            0xb2,0x74,0x60,0x43,0x18,0x9c,0xac,0x11,0xd5,0x23,0xfb,0x1b,0x71,0xae,0xf5,0x58,
            0x2e,0xe1,0x2a,0x3a,0xe6,0x6c,0xf8,0xa5,0x8a,0x9a,0x54,0x9b,0x50,0xc5,0x87,0x06,
            0xe8,0x75,0x5c,0x35,0xe4,0xe3,0x6b,0x52,0x90,0x38,0xca,0x73,0x3f,0xd1,0xaa,0xa8,
            0xda,0xb4,0x01,0x33,0xd8,0x03,0x20,0xe0,0x79,0x09,0x68,0xc7,0x65,0x46,0xb9,0x93
        };
        static byte[] sbox4 ={
            0xd6,0xef,0xbb,0x9b,0x93,0x4a,0x53,0x4e,0xb4,0xf3,0xf2,0x65,0x4f,0xde,0x73,0x19,
            0xab,0x98,0x22,0x26,0x5e,0x64,0xc5,0x16,0x58,0xba,0x47,0x3e,0x9e,0xbf,0xb1,0x76,
            0x92,0x6c,0x95,0x54,0xad,0xca,0xff,0x61,0x03,0x2f,0xb9,0x62,0xf4,0x13,0x3c,0xa6,
            0x90,0x35,0xf9,0x63,0xa9,0xd9,0x17,0x21,0x5d,0x68,0x2b,0x1e,0x51,0x7c,0x0a,0x6b,
            0xfc,0x48,0xe6,0xd7,0xc8,0x0d,0x83,0xa5,0x9f,0xa0,0xdc,0x01,0x69,0x0c,0xd4,0xa4,
            0xe1,0x7f,0x55,0x86,0x8f,0xdb,0x12,0xb8,0xb2,0xcc,0xb3,0xac,0x4c,0x18,0x74,0x7a,
            0x70,0x40,0x6f,0x60,0xf7,0xe8,0x72,0xbe,0xc4,0xc6,0x8c,0xdd,0x7e,0x79,0xc9,0x41,
            0xae,0x37,0x84,0xf6,0x39,0x80,0x05,0x8e,0x8d,0xce,0x11,0x59,0x43,0xe0,0x8a,0x6d,
            0xc0,0xfa,0x5b,0xcf,0xa8,0xfb,0x57,0x9c,0x89,0x56,0x06,0xe3,0x23,0x67,0x02,0xa3,
            0x87,0x66,0x97,0x42,0x00,0x49,0x88,0xea,0xf5,0x46,0xbc,0xb6,0xd0,0xd8,0x91,0x5c,
            0xb0,0x50,0xe7,0x82,0x45,0x29,0xe5,0xa2,0x31,0x15,0x77,0x4d,0xfe,0xec,0x99,0xb7,
            0xc2,0x4b,0x3b,0xaf,0x3a,0x96,0x28,0x0b,0xc7,0x30,0x3d,0x71,0xd2,0x08,0xd5,0xeb,
            0xee,0xe4,0xed,0x1f,0x07,0x34,0x1b,0xe9,0x9a,0x25,0x2c,0xda,0xc1,0x9d,0x2d,0x36,
            0x5f,0x44,0x75,0xf0,0x09,0xa1,0x10,0x1c,0x20,0x8b,0x94,0x1a,0xa7,0xd1,0x85,0x38,
            0x04,0x78,0xf1,0x52,0x0e,0x3f,0xe2,0x33,0xfd,0x32,0x2e,0xdf,0x14,0x7b,0xbd,0xb5,
            0x27,0xaa,0x2a,0xf8,0xcb,0x0f,0x7d,0x6e,0xd3,0x81,0xcd,0x6a,0xc3,0x5a,0x1d,0x24,
        };
        // this sbox come from the hexadecimal digit of e aka 2.7182818284590452353602874713527...
        static uint[] Skey1 =
        {
            0x9e3779b9,0x7f4a7c15,0xf39cc060,0x5cedc834,0x1082276b,0xf3a27251,0xf86c6a11,0xd0c18e95,
            0x2767f0b1,0x53d27b7f,0x0347045b,0x5bf1827f,0x01886f09,0x28403002,0xc1d64ba4,0x0f335e36,
            0xf06ad7ae,0x9717877e,0x85839d6e,0xffbd7dc6,0x64d325d1,0xc5371682,0xcadd0ccc,0xfdffbbe1,
            0x626e33b8,0xd04b4331,0xbbf73c79,0x0d94f79d,0x471c4ab3,0xed3d82a5,0xfec50770,0x5e4ae6e5,
            0xe73a9b91,0xf3aa4db2,0x87ae44f3,0x32e923a7,0x3cb91648,0xe428e975,0xa3781eb0,0x1b49d867,
            0x4fa15084,0x19e0eaa4,0x038b352d,0x9bad30f4,0x485b71a8,0xef64452a,0x0dd40dc8,0xcb8f9a2d,
            0x4c514f1b,0x229dcaa2,0x22ac268e,0x9666e4a8,0x66769145,0xf5f5880a,0x9d0acd3b,0x9e8c682f,
            0x4f810320,0xabeb9403,0x4e70f216,0x08c061ab,0x1c1caef1,0xebdcefbc,0x72134ecf,0x06ed82bf,
            0xb7d8eb1a,0x41901d65,0xf5c8cab2,0xaccbc32e,0xab1fbe82,0x84f2b44b,0xa2e834c5,0x893a39ea,
            0x7865443f,0x489c37f8,0x742acd89,0x5afd87b4,0x67d22a40,0xd098f30d,0xd2cafdeb,0x3abb3a13,
            0x507b46b3,0xd757fc04,0x001906e1,0x767d40c3,0xa3792a26,0xeeef2ab5,0xbd6685b9,0x15b56294,
            0x00faa684,0xecba752d,0xddcb5d18,0x576d77b6,0x52ac0d99,0x99736866,0x04128f0c,0xd4274359,
            0x6deb2d42,0xc789d64b,0x92658610,0xb5b95c71,0x9adeb8ce,0x28732634,0x4e31d59a,0x59963220,
            0xb1a4c427,0x71d454ec,0x78f12393,0xbfb4ac54,0x188e5911,0x3d7c3544,0x1f15aa34,0xa1140703,
            0x5f006fc3,0xad70fc0d,0x6331c6d4,0x79f484bf,0x39cbfbd9,0x5e664e39,0xbebdc5b0,0x9d9d5b8f,
            0x8905d980,0x5c819945,0x7d444a90,0x9316cc58,0xd38b3a25,0xc714be8d,0x422964e9,0x724c033b,
            0x6748acbc,0x2e05caaf,0x737c9562,0x2e6483fa,0x0707999a,0xfc482995,0x1701c6ed,0x5f27ce23,
            0x17709655,0x41f5f287,0x97f2fecb,0xd984d343,0x5ce547c8,0x8c38466e,0x28652356,0x83d4447e,
            0x4b327579,0x03058ca1,0x1a903f3b,0xaa386493,0x2b80a7d0,0x2d61b50c,0x1ff281d5,0xdd2947da,
            0x4624bbc7,0xc7b94962,0x717aed28,0x4395c42f,0x253c17f4,0x92f401bb,0x6c17a95c,0x3296b424,
            0xdb05afa8,0xe7ad2561,0xaca1f4fd,0x6e0eb57f,0x831e4022,0x7fbacd46,0x7ff8b7f8,0x4370aef7,
            0x11857634,0xd0cf4189,0x002dde87,0x87576c63,0x1f0b9a17,0x3c16b80e,0x7d941c12,0x8a540c91,
            0xd33a1daf,0x0f022298,0x6e3c7661,0xb2a7b374,0xdc06d839,0x6659e0fd,0xe9b7b41d,0xc1bbb0f4,
            0x2988d4d2,0x525906bd,0xf64a6ea5,0xb159f2ad,0xf7c883ce,0x8c4808a9,0xb46eb960,0xf7419201,
            0x0862bd1c,0x306500c6,0x795a0a29,0xdf4a34d4,0x2b1a418a,0x9fbcabd5,0x1e1887aa,0x0f8ebdf4,
            0x452d6efb,0x8d2948d8,0x878256e2,0xc6c33dc8,0xca89d68e,0x06aeabd5,0x6bca17de,0xa2358e44,
            0x3b567201,0xdbe25e06,0xa7451a73,0x6b14cfe3,0xaf438522,0x186524da,0xd69f054b,0x61cdbf1b,
            0xa9a54f46,0xff7a2a1e,0x5090e0a2,0x6dbe7766,0xebf40475,0xa2f166ab,0x6b1791b0,0xee0b48d8,
            0x63c08f80,0x9967ac68,0xa158a6b4,0xeefe4fae,0x8eb1d32c,0xfa6a4573,0x468c1374,0x01262ab7,
            0x893a30cb,0x015245b7,0x6fa16cf8,0x9db93647,0xbb74e258,0x1ae8823d,0x14c0343e,0xfb790b35,
            0x76421642,0x8d6e9856,0xdd074ee6,0xf411ee1b,0x5dd2a670,0xcce122bf,0x868be818,0x525e08f5,
            0xb8b3d940,0x252b853b,0x7248a83a,0xa561610f,0x17a35fc8,0x3e542a94,0xfcb71694,0xc229ef98
        }; // value came from phi aka 1.618....
        static uint[] Skey2 =
        {
            0xf50746a0,0x8c3fcd87,0x5ca4b94d,0x390bba41,0xe657f218,0x92b6ee0e,0xf705034a,0xccc46fc4,
            0xe1af7e9a,0x90ff984f,0xc20bd959,0x6a3da5be,0xca81a0ac,0x599947c1,0xf5eebf18,0xb16c96a1,
            0x2face935,0x01968c59,0xc16f7cd9,0x2e8a58d4,0x72335d81,0x6bbb85e1,0xcaa23ed2,0xa61cc0cd,
            0xbbb3700b,0x8bb3f966,0x9fc35903,0x47bc63f4,0xc5dcb9b2,0xa8c174ac,0xbadbdef7,0xdd61aa4d,
            0xff59fb3a,0xdca34b37,0xfd54fcdb,0xdeb68241,0x6a89edc6,0x5754aada,0xa3d5d5f3,0x29b92a98,
            0xa8f08c8d,0x6b6197de,0xc9b63286,0x673d2123,0xa78adb6e,0x162b9380,0x81682e15,0x456856ea,
            0x498bee3a,0xc11a0380,0x4078c842,0x6b1eeba9,0xafe94a60,0x2b0aca31,0xdcc753b0,0x38d74573,
            0xc8956b3e,0x674e419f,0x1582bdbd,0xad42f6aa,0x939a4326,0x3bf0f443,0x055ce37e,0x21a47cfe,
            0x58b36212,0x00296305,0x60f4937b,0xea45da7f,0x2b369176,0x24e961a9,0xb7c86dbf,0xa659c0bd,
            0x0a1381bd,0x30110ed1,0x4d5c3bbe,0x5a6d7426,0xc3c6f829,0x6054e13f,0x27509600,0x8e89fcb7,
            0x6380b8ef,0x94f45176,0xfa76ee96,0x4907dcdc,0xcbbc5e73,0x7e471e7c,0x11a53f2f,0x0c14c159,
            0xe17ff1a9,0xee756d4a,0x03fbaeea,0xe3a4fa42,0x70608d8c,0x63d133da,0x88fd7f9d,0xc502f236,
            0xa796a481,0x90f40c07,0x74648254,0xe2fdbdf0,0x4ca426e0,0xcf48af60,0x294e903b,0xc3803e13,
            0x49423630,0x8317f379,0xc1fc3433,0x419de44d,0x824bdc1c,0xfa4e855d,0x71685d96,0xe63521d7,
            0xb5a363f6,0x99b28edc,0x6240cea4,0xe1e8607e,0x861c9820,0xed76b53c,0x0db4c616,0xffdc1c3b,
            0xeac4269b,0xe86ff4a2,0xe5207614,0x90ca3adc,0xbd2526fd,0x46057cb2,0x9964792e,0xf96d7c42,
            0x36444a6b,0xd15f44c3,0x6855183f,0xf161b87f,0xd1ff69c0,0xa856bdd2,0x527e9ee9,0x7da383ff,
            0x7b3b5945,0xe93ef8d7,0xfc88ff69,0x23454df1,0x14691d7c,0x89ac32b5,0xaa7290bd,0x0e46c4a0,
            0xd8531772,0xd70dce98,0xc0171e69,0xea585838,0x75b1e2b1,0x7fa548b8,0x7f33957d,0x0c47e0d2,
            0x440fcc8d,0x4440e576,0xdae8bcb4,0xbafc566c,0xe7007049,0x6a65b400,0xc735a9bc,0x2d8ddda2,
            0x857d905e,0xfc44794e,0x857fdc71,0x357b21d7,0x69b24a17,0xb0c16843,0x5435654a,0x918e153f,
            0x34e39cea,0x6f4408c8,0xa156dcd1,0xb449a130,0x2b9b6688,0xf90bef71,0x318ebe56,0x28dcc117,
            0x88fdecc4,0x1fe83d1f,0x91a6b0d2,0x7708e404,0x7d67aa9c,0x8347ef46,0x9f919332,0x4cba0abc,
            0xfe0befec,0x1ca745a6,0xc1ef136e,0x0f73cd0f,0x4f4089ad,0x75cba6fd,0xed1d15ac,0x76f13444,
            0x478bfd03,0x7423a8c5,0xf1dbf1fd,0xee5f4757,0x367f0b45,0x440f3c67,0xbc31ceef,0x4a3d2f30,
            0x68ea7d85,0x9093baa6,0xa0aebb17,0x7fbfa671,0x728a43fe,0x73d640f8,0x03e18773,0x16b5477e,
            0xab167ff3,0x371cb6ad,0x9d059e63,0x08662037,0x9a963de1,0x19d1d875,0x1d45839b,0x652ccc16,
            0xeae1b5de,0xb9a1b1a8,0x4af38e26,0x521e93de,0x82dc5758,0xaf39b35b,0xd4e6df91,0x3fe32ea1,
            0x432f470a,0x4d8de47e,0x875bb8b6,0xbb903c56,0xa25f7d18,0x8f9e0e2d,0x17866c87,0x7bd93d5d,
            0x997a36a7,0x9c9e4a9b,0x6256e663,0xfe1b1b0e,0x1a10650a,0x11f568d3,0xe24482f9,0x7caea648,
            0x57772ba4,0xf63aadda,0x4363208e,0x7805b4f9,0x104a7e05,0x07a119eb,0x1ba22964,0x4e660722,
            0x6693d15a,0xc676fd02,0x53c3bba3,0xc5ccda95,0xed509838,0xeda3fd00,0x47515572,0xbdbfe7db
        };
        private static ushort RotL16(ushort x, byte s)
        {
            return (ushort)((x << s) | (x >> (16 - s)));
        }
        private static ushort RotR16(ushort x, byte s)
        {
            return (ushort)((x >> s) | (x << (16 - s)));
        }
        private static uint RotR32(uint x, byte s)
        {
            return (x >> s) | (x << (32 - s));
        }
        private static uint RotL32(uint x, byte s)
        {
            return (x << s) | (x >> (32 - s));
        }
        private static uint f(uint x)
        {
            x = RotL32(x, 24) + RotL32(x, 15) ^ RotL32(x, 6) + RotR32(x, 3);
            x = (uint)(((sbox4[(x >> 24) & 255]) << 24) | (sbox3[((x >> 16)) & 255] << 16) | ((sbox2[(x >> 8) & 255]) << 8) | sbox1[x & 255]);
            return x;
        }

        private static ulong[] B64(byte[] input)
        {
            int len = input.Length;
            while ((len & 7) != 0)
            {
                len++;
            }
            byte[] padded = new byte[len];
            Array.Copy(input, padded, input.Length);
            ulong[] block = new ulong[len >> 3];
            for (int i = 0; i < len; i += 8)
            {
                block[i >> 3] = ((ulong)padded[i] << 56) | ((ulong)padded[i | 1] << 48) | ((ulong)padded[i | 2] << 40) | ((ulong)padded[i | 3] << 32) | ((ulong)padded[i | 4] << 24) | ((ulong)padded[i | 5] << 16) | ((ulong)padded[i | 6] << 8) | padded[i | 7];
            }
            return block;
        }
        private static byte[] UB64(ulong[] input)
        {
            int tmp;
            byte[] outp = new byte[input.Length << 3];
            for (int i = 0; i < input.Length; i++)
            {
                tmp = i << 3;
                outp[tmp] = (byte)(input[i] >> 56);
                outp[tmp | 1] = (byte)(input[i] >> 48);
                outp[tmp | 2] = (byte)(input[i] >> 40);
                outp[tmp | 3] = (byte)(input[i] >> 32);
                outp[tmp | 4] = (byte)(input[i] >> 24);
                outp[tmp | 5] = (byte)(input[i] >> 16);
                outp[tmp | 6] = (byte)(input[i] >> 8);
                outp[tmp | 7] = (byte)input[i];
            }
            return outp;
        }
        private static ushort[] B16(byte[] input)
        {
            int len = input.Length + (input.Length & 1);
            byte[] padded = new byte[len];
            Array.Copy(input, padded, input.Length);
            ushort[] block = new ushort[len >> 1];
            for (int i = 0; i < len; i += 2)
            {
                block[i >> 1] = (ushort)((padded[i] << 8) | padded[i | 1]);
            }
            return block;
        }
        public static byte[] Encrypt(byte[] text, byte[] key)
        {
            uint[] sk = new uint[8];
            ushort[] mk = B16(key);
            int count, count1 = 0, a, b, c, t0 = 0, t1, t2;
            sk[0] = 0x243F6A88;
            sk[1] = 0x85A308D3;
            sk[2] = 0x13198A2E;
            sk[3] = 0x03707344;
            sk[4] = 0xA4093822;
            sk[5] = 0x299F31D0;
            sk[6] = 0x082EFA98;
            sk[7] = 0xEC4E6C89;
            for (int k = 0; k < 64; k++)
            {
                t0 += RotL16(mk[count = (count1 + 6) & 15], 1) ^ RotL16(mk[count], 6) ^ RotL16(mk[count], 15);
                t0 += RotR16(mk[12], 3);
                t0 += mk[count = (count1 + 15) & 15] ^ RotL16(mk[count], 9) ^ RotL16(mk[count], 14);
                mk[count] = (ushort)t0;
                t1 = (int)(((sk[a = (count1 + 4) & 7] + sk[b = (count1 + 5) & 7]) ^ (sk[a] + sk[c = (count1 + 6) & 7]) ^ (sk[b] + sk[c])) + Skey1[mk[count] >> 8] + Skey1[mk[count] & 255] + sk[count1 & 7]);
                t2 = (int)(((sk[a = (count1 + 1) & 7] + sk[b = (count1 + 2) & 7]) ^ (sk[a] + sk[c = (count1 + 3) & 7]) ^ (sk[b] + sk[c])) + sk[7]);
                sk[c] += (uint)t1;
                sk[count1 & 7] += (uint)(t1 ^ t2);
                t0 = 0;
                count1++;
            }
            void Generate()
            {
                t0 += RotL16(mk[count = (count1 + 6) & 15], 1) ^ RotL16(mk[count], 6) ^ RotL16(mk[count], 15);
                t0 += RotR16(mk[12], 3);
                t0 += mk[count = (count1 + 15) & 15] ^ RotL16(mk[count], 9) ^ RotL16(mk[count], 14);
                mk[count] = (ushort)t0;
                t1 = (int)(((sk[a = (count1 + 4) & 7] + sk[b = (count1 + 5) & 7]) ^ (sk[a] + sk[c = (count1 + 6) & 7]) ^ (sk[b] + sk[c])) + Skey1[mk[count] >> 8] + Skey1[mk[count] & 255] + sk[count1 & 7]);
                t2 = (int)(((sk[a = (count1 + 1) & 7] + sk[b = (count1 + 2) & 7]) ^ (sk[a] + sk[c = (count1 + 3) & 7]) ^ (sk[b] + sk[c])) + sk[7]);
                sk[c] += (uint)t1;
                sk[count1 & 7] += (uint)(t1 ^ t2);
                t0 = 0;
                count1++;
            }


            ulong[] block = B64(text);
            for (int i = 0; i < block.Length; i++)
            {
                uint Left = (uint)(block[i] >> 32);
                uint Right = (uint)block[i];
                uint tmp;
                for (int j = 0; j < 16; j++)
                {
                    Generate();
                    Left ^= f(Right ^ sk[count1 & 7]);

                    tmp = Left;
                    Left = Right;
                    Right = tmp;
                }
                block[i] = ((ulong)Right << 32) | Left;
            }

            byte[] outp = UB64(block);
            return outp;
        }
        public static byte[] Decrypt(byte[] text, byte[] key)
        {
            uint[] sk = new uint[8];
            ushort[] mk = B16(key);
            int count, count1 = 0, a, b, c, t0 = 0, t1, t2;
            sk[0] = 0x243F6A88;
            sk[1] = 0x85A308D3;
            sk[2] = 0x13198A2E;
            sk[3] = 0x03707344;
            sk[4] = 0xA4093822;
            sk[5] = 0x299F31D0;
            sk[6] = 0x082EFA98;
            sk[7] = 0xEC4E6C89;
            for (int k = 0; k < 64; k++)
            {
                t0 += RotL16(mk[count = (count1 + 6) & 15], 1) ^ RotL16(mk[count], 6) ^ RotL16(mk[count], 15);
                t0 += RotR16(mk[12], 3);
                t0 += mk[count = (count1 + 15) & 15] ^ RotL16(mk[count], 9) ^ RotL16(mk[count], 14);
                mk[count] = (ushort)t0;
                t1 = (int)(((sk[a = (count1 + 4) & 7] + sk[b = (count1 + 5) & 7]) ^ (sk[a] + sk[c = (count1 + 6) & 7]) ^ (sk[b] + sk[c])) + Skey1[mk[count] >> 8] + Skey1[mk[count] & 255] + sk[count1 & 7]);
                t2 = (int)(((sk[a = (count1 + 1) & 7] + sk[b = (count1 + 2) & 7]) ^ (sk[a] + sk[c = (count1 + 3) & 7]) ^ (sk[b] + sk[c])) + sk[7]);
                sk[c] += (uint)t1;
                sk[count1 & 7] += (uint)(t1 ^ t2);
                t0 = 0;
                count1++;
            }
            void Generate()
            {
                t0 += RotL16(mk[count = (count1 + 6) & 15], 1) ^ RotL16(mk[count], 6) ^ RotL16(mk[count], 15);
                t0 += RotR16(mk[12], 3);
                t0 += mk[count = (count1 + 15) & 15] ^ RotL16(mk[count], 9) ^ RotL16(mk[count], 14);
                mk[count] = (ushort)t0;
                t1 = (int)(((sk[a = (count1 + 4) & 7] + sk[b = (count1 + 5) & 7]) ^ (sk[a] + sk[c = (count1 + 6) & 7]) ^ (sk[b] + sk[c])) + Skey1[mk[count] >> 8] + Skey1[mk[count] & 255] + sk[count1 & 7]);
                t2 = (int)(((sk[a = (count1 + 1) & 7] + sk[b = (count1 + 2) & 7]) ^ (sk[a] + sk[c = (count1 + 3) & 7]) ^ (sk[b] + sk[c])) + sk[7]);
                sk[c] += (uint)t1;
                sk[count1 & 7] += (uint)(t1 ^ t2);
                t0 = 0;
                count1++;
            }

            ulong[] block = B64(text);
            uint[] RoundKey = new uint[16];
            for (int i = 0; i < block.Length; i++)
            {
                uint Left = (uint)(block[i] >> 32);
                uint Right = (uint)block[i];
                uint tmp;
                for (int j = 0; j < 16; j++)
                {
                    Generate();

                    RoundKey[j] = sk[count1 & 7];
                }
                for (int j = 15; j > -1; j--)
                {
                    Left ^= f(Right ^ RoundKey[j]);

                    tmp = Left;
                    Left = Right;
                    Right = tmp;
                }
                block[i] = ((ulong)Right << 32) | Left;
            }

            byte[] outp = UB64(block);
            return outp;
        }
        public static string EncryptString(string data, byte[] key)
        {
            byte[] text = Encoding.ASCII.GetBytes(data);
            return Convert.ToBase64String(Encrypt(text, key));
        }
        public static string DecryptString(string data, byte[] key)
        {
            byte[] text = Convert.FromBase64String(data);
            return Encoding.ASCII.GetString(Decrypt(text, key));
        }
    }
}
namespace testeeews
{
    static class Program
    {
        private static void ClearColor()
        {
            Console.BackgroundColor = ConsoleColor.Black;
        }
        private static void Display()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            string[] e = {
                "██╗   ██╗███╗   ██╗██╗    ██╗███████╗██╗      ██████╗ ██████╗ ███╗   ███╗███████╗",
                "██║   ██║████╗  ██║██║    ██║██╔════╝██║     ██╔════╝██╔═══██╗████╗ ████║██╔════╝",
                "██║   ██║██╔██╗ ██║██║ █╗ ██║█████╗  ██║     ██║     ██║   ██║██╔████╔██║█████╗  ",
                "██║   ██║██║╚██╗██║██║███╗██║██╔══╝  ██║     ██║     ██║   ██║██║╚██╔╝██║██╔══╝  ",
                "╚██████╔╝██║ ╚████║╚███╔███╔╝███████╗███████╗╚██████╗╚██████╔╝██║ ╚═╝ ██║███████╗",
                " ╚═════╝ ╚═╝  ╚═══╝ ╚══╝╚══╝ ╚══════╝╚══════╝ ╚═════╝ ╚═════╝ ╚═╝     ╚═╝╚══════╝"
            };
            string ae = "";
            foreach (string u in e)
            {
                ae += u + "\r\n";
            }
            
        }
        public static void ClearCurrentConsoleLine(int line)
        {
            Console.SetCursorPosition(0, Console.CursorTop - line + 1);
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }
        static void Main()
        {

            while (true)
            {
                Display();
                ClearColor();
                Console.WriteLine(@"██╗   ██╗███╗   ██╗██╗    ██╗███████╗██╗      ██████╗ ██████╗ ███╗   ███╗███████╗
██║   ██║████╗  ██║██║    ██║██╔════╝██║     ██╔════╝██╔═══██╗████╗ ████║██╔════╝
██║   ██║██╔██╗ ██║██║ █╗ ██║█████╗  ██║     ██║     ██║   ██║██╔████╔██║█████╗  
██║   ██║██║╚██╗██║██║███╗██║██╔══╝  ██║     ██║     ██║   ██║██║╚██╔╝██║██╔══╝  
╚██████╔╝██║ ╚████║╚███╔███╔╝███████╗███████╗╚██████╗╚██████╔╝██║ ╚═╝ ██║███████╗
 ╚═════╝ ╚═╝  ╚═══╝ ╚══╝╚══╝ ╚══════╝╚══════╝ ╚═════╝ ╚═════╝ ╚═╝     ╚═╝╚══════╝
                                                                                 ");
                Console.WriteLine(@"[public distribution]
");
                Console.WriteLine("Press [E] to encrypt");
                Console.WriteLine("Press [D] to decrypt");
                Console.WriteLine("Press [X] to exit");
                Console.Write("  >>   ");
                var Ckey = Console.ReadKey().Key;
                if (Ckey == ConsoleKey.X)
                {

                    Console.Clear();
                    Console.WriteLine("press any key to exit..."); Console.ReadKey(true); Environment.Exit(0);

                }
                if (Ckey == ConsoleKey.E)
                {
                    Console.Clear();
                    Console.WriteLine(@"███████╗███╗   ██╗ ██████╗██████╗ ██╗   ██╗██████╗ ████████╗
██╔════╝████╗  ██║██╔════╝██╔══██╗╚██╗ ██╔╝██╔══██╗╚══██╔══╝
█████╗  ██╔██╗ ██║██║     ██████╔╝ ╚████╔╝ ██████╔╝   ██║   
██╔══╝  ██║╚██╗██║██║     ██╔══██╗  ╚██╔╝  ██╔═══╝    ██║   
███████╗██║ ╚████║╚██████╗██║  ██║   ██║   ██║        ██║   
╚══════╝╚═╝  ╚═══╝ ╚═════╝╚═╝  ╚═╝   ╚═╝   ╚═╝        ╚═╝   
                                                            ");
                    Console.Write("plaintext >>  ");
                    string data = Console.ReadLine();
                    Console.Write("key >>  ");
                    byte[] key = Encoding.ASCII.GetBytes(Console.ReadLine().PadRight(32, '\0'));
                    Console.Write("encrypted text >>  ");
                    string ENCRYPTED = UNW5.EncryptString(data, key);
                    int alrLEN = ENCRYPTED.Length / 2;
                    string one = ENCRYPTED.Substring(0, alrLEN);
                    string two = ENCRYPTED.Substring(alrLEN);
                    string final = two + one;
                    Console.WriteLine("UNW.PUB." + final);
                    Console.Write("Press [Enter] to continue >>  ");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (Ckey == ConsoleKey.D)
                {
                    Console.Clear();
                    Console.WriteLine(@"██████╗ ███████╗ ██████╗██████╗ ██╗   ██╗██████╗ ████████╗
██╔══██╗██╔════╝██╔════╝██╔══██╗╚██╗ ██╔╝██╔══██╗╚══██╔══╝
██║  ██║█████╗  ██║     ██████╔╝ ╚████╔╝ ██████╔╝   ██║   
██║  ██║██╔══╝  ██║     ██╔══██╗  ╚██╔╝  ██╔═══╝    ██║   
██████╔╝███████╗╚██████╗██║  ██║   ██║   ██║        ██║   
╚═════╝ ╚══════╝ ╚═════╝╚═╝  ╚═╝   ╚═╝   ╚═╝        ╚═╝   
                                                          ");
                    Console.Write("ciphertext >>  ");
                    string jej = Console.ReadLine();
                    int index = jej.IndexOf("UNW.PUB.");
                    string encodedFR = jej.Substring(index + 8);
                    int ps1LEN = encodedFR.Length / 2;
                    string ps2 = encodedFR.Substring(0, ps1LEN);
                    string ps2_2 = encodedFR.Substring(ps1LEN);
                    string data = ps2_2 + ps2;
                    Console.Write("key >>  ");
                    byte[] key = Encoding.ASCII.GetBytes(Console.ReadLine().PadRight(32, '\0'));
                    Console.Write("decrypted text >>  ");
                    Console.WriteLine(UNW5.DecryptString(data, key));
                    Console.Write("Press [Enter] to continue >>  ");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                }
            }
        }
    }
}
