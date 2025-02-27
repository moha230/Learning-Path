

# npm 

ubiquitous

package manager

Broadly speaking, a package manager’s two primary responsibilities
are installing packages and managing dependencies

The -g flag tells npm to install the package globally, meaning it’s
available globally on the system. This distinction will become clearer
when we cover the package.json files. For now, the rule of thumb is
that JavaScript utilities (like nodemon) will generally be installed
globally, whereas packages that are specific to your web app or
project will not.

# A Simple Web Server with Node

localhost as the name implies refers to the computer you are on . This is common alias for IP4 loopback address 
127.0.0.1

::1 ipv6 

Node offers a different paradigm than that of a traditional web server:
the app that you write is the web server. Node simply provides the
framework for you to build a web server.


This means that **Node.js does not operate like traditional web servers** (e.g., Apache, Nginx) that passively wait for requests and serve files from a predefined structure. Instead, in Node.js, **your application itself acts as the web server**, meaning you define how it listens for and handles requests.  

### Traditional Web Server (e.g., Apache, Nginx):  
- The server is pre-configured and runs separately.  
- It handles HTTP requests, serving static files and forwarding dynamic requests to backend scripts (e.g., PHP, Python).  
- Your application code runs within this predefined environment.  

### Node.js Paradigm:  
- You **write** the logic that determines how requests are handled.  
- Your app creates an HTTP server **from scratch**, defining its own request handling, routing, and response logic.  
- Node.js provides the **framework** (like the `http` module or frameworks like Express.js) to help you build this server.  

### Example:
A simple Node.js web server using the built-in `http` module:  

```javascript
const http = require('http');

const server = http.createServer((req, res) => {
  res.writeHead(200, { 'Content-Type': 'text/plain' });
  res.end('Hello, World!');
});

server.listen(3000, () => {
  console.log('Server running on port 3000');
});
```
- Here, **your app is the server**.  
- It listens on port `3000` and directly handles requests.  
- You define how to respond to requests rather than relying on a pre-configured web server.  

This approach gives **more flexibility and efficiency**, especially for handling real-time applications (e.g., chat apps, APIs) but requires more manual setup compared to traditional web servers.


# Event-Driven Programming

The core philosophy behind node is that of event driven programming event are avaialabe to you and how to respond to them.

How your application responds to that navigation event is referred 
to as **routing**

# routing 

Routing refers to the mechanism for serving the client the content it
has asked for

for web based client /server applications the client specifies the deserid content in the URL  

**specifically, the path and querystring** 

> Server routing traditionally hinges on the path and the querystring, but there is otherinformation available: headers, the domain, the IP address, and more. This allows servers
to take into consideration, for example, the approximate physical location of the user or
the preferred language of the user.

# Serving Static Resources

static respurces becouse they dont change 

Sure! Below are examples of how **Apache** and **Node.js** serve an HTML file.

---

## **1. Apache (Automatic File Serving)**
Apache automatically serves an HTML file when placed in its web directory.

### **Steps:**
1. Place an HTML file (`index.html`) inside Apache’s web root directory:
   - **Linux:** `/var/www/html/`
   - **Windows (XAMPP):** `C:\xampp\htdocs\`

2. Restart Apache:
   ```bash
   sudo systemctl restart apache2  # Ubuntu/Debian
   sudo systemctl restart httpd    # CentOS/RHEL
   ```
3. Open a browser and visit:
   ```
   http://localhost/index.html
   ```

👉 Apache automatically finds `index.html` and serves it without extra code.

---

## **2. Node.js (Manually Serving an HTML File)**
With Node.js, you need to **open, read, and send** the file manually.

### **Example: Creating a Simple HTTP Server**
Create a file called `server.js`:

```javascript
const http = require('http');
const fs = require('fs');
const path = require('path');

const server = http.createServer((req, res) => {
    // Read the index.html file
    fs.readFile(path.join(__dirname, 'index.html'), (err, data) => {
        if (err) {
            res.writeHead(500, { 'Content-Type': 'text/plain' });
            res.end('Internal Server Error');
        } else {
            res.writeHead(200, { 'Content-Type': 'text/html' });
            res.end(data);
        }
    });
});

// Start the server
const PORT = 3000;
server.listen(PORT, () => {
    console.log(`Server running at http://localhost:${PORT}`);
});
```

### **Steps to Run Node.js Server**
1. Create `index.html` in the same directory as `server.js`.
2. Run the server:
   ```bash
   node server.js
   ```
3. Open a browser and visit:
   ```
   http://localhost:3000
   ```

👉 Unlike Apache, **Node.js requires explicit file handling** to serve HTML.

Would you like to extend this Node.js example (e.g., adding Express.js for easier routing)? 🚀