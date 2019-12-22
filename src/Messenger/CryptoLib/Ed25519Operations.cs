﻿using System;
using System.Security.Cryptography;

namespace CryptoLib
{
    public static class Ed25519Operations
    {
        public static void crypto_sign_keypair(byte[] pk, int pkoffset, byte[] sk, int skoffset, byte[] seed, int seedoffset)
        {
            GroupElementP3 A;
            int i;

            Array.Copy(seed, seedoffset, sk, skoffset, 32);
            byte[] h = Sha512.Hash(sk, skoffset, 32);
            ScalarOperations.sc_clamp(h, 0);

            GroupOperations.ge_scalarmult_base(out A, h, 0);
            GroupOperations.ge_p3_tobytes(pk, pkoffset, ref A);

            //for (i = 0; i < 32; ++i) sk[skoffset + Ed25519.Offset + i] = pk[pkoffset + i];
            CryptoBytes.Wipe(h);
        }

    }
}