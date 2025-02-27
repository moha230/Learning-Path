commadn used to generate private key 

ssh-keygen


Generating public/private ed25519 key pair.
Enter file in which to save the key (/home/fahad/.ssh/id_ed25519):


3. Use ssh-copy-id to Install Your Key on a Remote Server
If you want to use ssh-copy-id to automatically copy your public key to a remote server, use this command:

ssh-copy-id username@remote-host
Replace username with your username on the remote machine and remote-host with the IP address or domain name of the server you're connecting to.

