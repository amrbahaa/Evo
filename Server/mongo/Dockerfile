#refrence: http://blog.bejanalex.com/2017/03/running-mongodb-in-a-docker-container-with-authentication/
FROM mongo:3.4.9

ENV AUTH yes
ENV STORAGE_ENGINE wiredTiger
ENV JOURNALING yes

ADD run.sh /run.sh
ADD set_mongodb_password.sh /set_mongodb_password.sh
RUN chmod +x /run.sh /set_mongodb_password.sh

CMD ["/run.sh"]