import java.net.ServerSocket;
import java.net.Socket;

public class WebServer {
	private static final int port = 1090;
	private void startServer() {
		ServerSocket serverSocket;

		try {
			serverSocket = new ServerSocket(port);
			System.out.println("Listening to connections on port " + port);

			while (true) {
				Thread thread = new Thread(new WebServerThread(serverSocket.accept()));
				thread.start();
			}
		} catch (Exception e) {
			e.printStackTrace();
		}
	}

	public static void main(String[] args) {
		WebServer ws = new WebServer();
		ws.startServer();
	}
}