import java.net.Socket;
import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.io.DataOutputStream;

public class WebClient {
	public static void main(String[] args) {
		try {
			Socket socket = new Socket("localhost", 1090);
			DataOutputStream netOut;
			netOut = new DataOutputStream(socket.getOutputStream());
			BufferedReader netIn = new BufferedReader(new InputStreamReader(socket.getInputStream()));
			String peticion = "GET /WebServer.java HTTP/1.1\n\r\n\r";
			netOut.writeBytes(peticion);

			String resp = "";
			while ((resp = netIn.readLine()) != null) {
				System.out.println(resp);
			}
			socket.close();
		} catch (Exception e) {
		}
	}
}