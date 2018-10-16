# DigitalEncryption
A .Net lightweight library for encryption and decryption of data i.e. passwords

# Usage
-------
-Use the Nuget Manager to locate and install the package i.e.

Install-Package DigitalEncryption.Utility

# Methods
----------
-The main class that implements the encryption and decryption services is called EncryptionService

-It contains methods to encrypt and decrypt data

# Implementation
----------------
Namespace-------->using EncryptionLib

# instantiate the class
------------------------
var encryptionService=new EncryptionService();//instantiate the class


# Encryption
------------
var encryptedData=encryptionService.EncryptData("data to encrypt")

-The encryptedData returns a model with data that will be required to decrypt the encrypted message.

-The model has a key,iv and the encrypted message.

-Save the above for later use.

# Decryption
------------
var decryptedData=encryptionService.DecryptData({encryptedData.EncryptedMessage} ,{encryptedData.Key}, {encryptedData.IV)}

-Returns the original data.
