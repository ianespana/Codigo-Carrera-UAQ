import java.io.*;
import java.net.Socket;

public class WebServerThread implements Runnable {
    private static final String dir = "C:\\Users\\ianes\\Documents\\GitHub\\Codigo-Carrera-UAQ\\Sistemas Distribuidos\\Actividades\\Basic Web Server\\WebServer\\src";
    private Socket socket;
    private BufferedReader netIn;
    private DataOutputStream netOut;

    private String headRequest() throws Exception {
        return "HTTP/1.1 200 OK";
    }

    private String getRequest(String[] tokens) throws Exception {
        String docRoute = dir + tokens[1];
        File file = new File(docRoute);

        if (!file.exists()) return "HTTP/1.1 404 Not Found";
        int fileSize = (int) file.length();

        String res = "";
        res = "HTTP/1.1 200 OK";
        res += "\nContent-language: en";
        res += "\nContent-Length: " + fileSize;
        res += "\nContent-Type**: text/html; charset=utf-8";
        res += "\nServer: My Server/1.6.2";
        this.netOut.writeBytes(res + "\n\r\n\r");

        FileInputStream fileInputStream = new FileInputStream(docRoute);
        byte[] buffer = new byte[fileSize];
        fileInputStream.read(buffer, 0, fileSize);
        this.netOut.write(buffer, 0, fileSize);
        return "";
    }

    private String postRequest(String[] tokens) throws Exception {
        return "";
    }

    private void generateResponse(String petition) throws Exception {
        String res = "";
        String[] tokens = petition.split(" ");
        switch (tokens[0]) {
            case "HEAD" -> res = headRequest();
            case "GET" -> res = getRequest(tokens);
            case "POST" -> res = postRequest(tokens);
            default -> res = "HTTP/1.1 400 Bad Request";
        }

        this.netOut.writeBytes(res);
    }

    public WebServerThread (Socket socket) throws Exception {
        this.socket = socket;
        this.netIn = new BufferedReader(new InputStreamReader(socket.getInputStream()));
        this.netOut = new DataOutputStream(socket.getOutputStream());
    }

    @Override
    public void run() {
        try {
            String request = netIn.readLine();
            if (request != null) {
                generateResponse(request);
            }
            socket.close();
        } catch (Exception e) {
            e.printStackTrace();
        }
    }
}
