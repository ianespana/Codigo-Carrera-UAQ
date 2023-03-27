import java.io.*;
import java.net.Socket;
import java.util.Arrays;

public class TCPChatServerWorker extends Thread {
    private final Socket socket;
    private final TCPChatServer tcpChatServer;
    private DataOutputStream writer;
    private String username = "";
    private String host = "";

    public TCPChatServerWorker(Socket socket, TCPChatServer tcpChatServer) throws IOException {
        this.socket = socket;
        this.tcpChatServer = tcpChatServer;
    }

    public void run() {
        try {
            InputStream input = socket.getInputStream();
            DataInputStream reader = new DataInputStream(input);
            writer = new DataOutputStream(socket.getOutputStream());

            String clientMessage;
            do {
                clientMessage = reader.readUTF();
            } while (!processMessage(clientMessage));

            tcpChatServer.removeWorker(this);
            socket.close();
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    private boolean processMessage(String message) throws Exception {
        String[] tokens = message.split("\\^");

        switch (tokens[0]) {
            case "m" -> onMessage(tokens);
            case "j" -> onJoin(tokens);
            case "p" -> {
                onPart(tokens);
                return true;
            }
        }
        return false;
    }

    public void sendMessage(String message) throws IOException {
        writer.writeUTF(message);
    }

    private void onMessage(String[] tokens) throws IOException {
        String message = String.join("^", tokens);
        tcpChatServer.broadcast(message, this);
    }

    private void onJoin(String[] tokens) throws IOException {
        String[] userDetails = tokens[1].split("@");
        this.username = userDetails[0];
        this.host = userDetails[1];
        tcpChatServer.broadcast("m^Server^-^" + this.username + " has joined the chat^", this);
        System.out.println(tokens[1] + " joined the chat");
    }

    private void onPart(String[] tokens) throws IOException {
        tcpChatServer.broadcast("m^Server^-^" + this.username + " has left the chat^", this);
        System.out.println(tokens[1] + " left the chat");
    }

    public String getUsername() {
        return username;
    }

    public String getHost() {
        return host;
    }
}
