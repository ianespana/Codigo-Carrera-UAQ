import java.io.*;
import java.net.Socket;
import java.util.Arrays;

public class FTPClient {
	public static void main(String[] args) {
		try {
			Socket socket = new Socket("localhost", 1090);
			DataOutputStream netOut = new DataOutputStream(socket.getOutputStream());
			DataInputStream netIn = new DataInputStream(socket.getInputStream());

			BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(System.in));
			String resp = "";
			do {
				String request = bufferedReader.readLine();
				netOut.writeUTF(request);

				resp = netIn.readUTF();
				System.out.println(resp);
			} while (!resp.equals("CLOSE"));

			socket.close();
		} catch (Exception e) {
		}
	}
}