thisdir = class/System.Data.Linq
SUBDIRS = 
include ../../build/rules.make

LIBRARY = System.Data.Linq.dll
LIB_REFS = System System.Core System.Xml System.Data System.Runtime.Serialization
LIB_MCS_FLAGS = \
	        /resource:./src/DbLinq/Schema/Dbml/DbmlSchema.xsd,DbLinq.Schema.Dbml.DbmlSchema.xsd \
		/d:MONO_STRICT /d:MONO_DEPLOY -warn:1

TEST_MCS_FLAGS = $(LIB_MCS_FLAGS)

EXTRA_DISTFILES = src/DbLinq/Schema/Dbml/DbmlSchema.xsd

# This is a .NET 3.5+ assembly
VALID_PROFILE := $(filter xammac_net_4_5 net_4_5, $(PROFILE))
ifndef VALID_PROFILE
LIBRARY_NAME = dummy-System.Data.Linq.dll
NO_INSTALL = yes
NO_SIGN_ASSEMBLY = yes
NO_TEST = yes
endif

include ../../build/library.make

dist-local: dist-default dist-DbLinq

dist-DbLinq:
	find src -name '*.cs' -o -name '*.snk' -o -name '*.xml' -o -name '*.txt' > .files ; \
	tar cTf .files - | (cd $(distdir); tar xf -) ; \
	rm .files

RSYNC_EXCLUDES = \
	--exclude '*.cache'         \
	--exclude '*.csproj.*.txt'  \
	--exclude '*.dll'           \
	--exclude '*.exe'           \
	--exclude '*.force'         \
	--exclude '*.pdb'           \
	--exclude '*.pidb'          \
	--exclude '*.suo'           \
	--exclude '*.user'          \
	--exclude '*.userprefs'     \
	--exclude '*.usertasks'     \
	--exclude '.svn' 

update-dblinq:
	rsync -avz $(RSYNC_EXCLUDES) $$HOME/Development/mono-HEAD/dblinq2007/src/ src/
	rsync -avz $(RSYNC_EXCLUDES) $$HOME/Development/mono-HEAD/dblinq2007/tests/ tests/
	rsync -avz $(RSYNC_EXCLUDES) $$HOME/Development/mono-HEAD/dblinq2007/examples/ examples/

