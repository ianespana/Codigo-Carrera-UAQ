FROM node:18-alpine

WORKDIR /opt/app

COPY package.json ./
COPY yarn.lock ./

RUN yarn

COPY ./ /opt/app/

CMD ["node", "/opt/app/app/index.js"]
