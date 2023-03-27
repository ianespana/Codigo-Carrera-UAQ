import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;
import java.util.*;

public class TCPChatServer {
    private int port;
    private final Set<TCPChatServerWorker> workerThreads = new HashSet<>();
    public TCPChatServer(int port) {
        this.port = port;
    }

    public void execute() {
        try (ServerSocket serverSocket = new ServerSocket(port)) {

            System.out.println("Server is listening on port " + port);

            while (true) {
                Socket socket = serverSocket.accept();
                TCPChatServerWorker newWorker = new TCPChatServerWorker(socket, this);
                this.workerThreads.add(newWorker);
                newWorker.start();
            }
        } catch (IOException e) {
            System.out.println("Error in the server: " + e.getMessage());
            e.printStackTrace();
        }
    }

    void broadcast(String message, TCPChatServerWorker excludeWorker) throws IOException {
        for (TCPChatServerWorker worker : workerThreads) {
            //if (worker != excludeWorker) {
                worker.sendMessage(message);
            //}
        }
    }

    void removeWorker(TCPChatServerWorker worker) {
        workerThreads.remove(worker);
    }

    public static void main(String[] args) {
        int port = 1090;
        if (args.length > 0) {
            port = Integer.parseInt(args[0]);
        }

        TCPChatServer server = new TCPChatServer(port);
        server.execute();
    }
}
