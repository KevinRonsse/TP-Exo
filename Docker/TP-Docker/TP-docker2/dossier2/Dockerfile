FROM ubuntu

RUN apt-get update
RUN apt-get install -y nginx
RUN git clone https://github.com/KevinRonsse/TP-Exo.git
ADD identity /var/www/html

EXPOSE 80

CMD ["nginx", "-g", "daemon off;"]